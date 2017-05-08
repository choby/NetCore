using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Loader;
using System.Text.RegularExpressions;

namespace Inman.Infrastructure.Common
{
    /// <summary>
    /// A class that finds types needed by Nop by looping assemblies in the 
    /// currently executing AppDomain. Only assemblies whose names matches
    /// certain patterns are investigated and an optional list of assemblies
    /// referenced by <see cref="AssemblyNames"/> are always investigated.
    /// </summary>
    public class AppDomainTypeFinder : ITypeFinder
    {
        #region Private Fields

        

        private string assemblySkipLoadingPattern = "^System|^mscorlib|^Microsoft|^CppCodeProvider|^VJSharpCodeProvider|^WebDev|^Castle|^Iesi|^log4net|^NHibernate|^nunit|^TestDriven|^MbUnit|^Rhino|^QuickGraph|^TestFu|^Telerik|^ComponentArt|^MvcContrib|^AjaxControlToolkit|^Antlr3|^Remotion|^Recaptcha|^Aspose.BarCode|^PetaPoco|^Newtonsoft|^NuGet|^Kendo|^Autofac|^Google|^Grpc|^IdentityModel|^Thrift|^Remotion|^AutoMapper|^BouncyCastle|^Dapper";

        private string assemblyRestrictToLoadingPattern = ".*";
        private IList<string> assemblyNames = new List<string>();
       
        #endregion

        #region Constructors

        /// <summary>Creates a new instance of the AppDomainTypeFinder.</summary>
        public AppDomainTypeFinder()
        {
           
        }

        #endregion

        #region Properties

        /// <summary>The app domain to look for types in.</summary>
        //public virtual AppDomain App
        //{
        //    get { return AppDomain.CurrentDomain; }
        //}

        

        /// <summary>Gets or sets assemblies loaded a startup in addition to those loaded in the AppDomain.</summary>
        public IList<string> AssemblyNames
        {
            get { return assemblyNames; }
            set { assemblyNames = value; }
        }

        /// <summary>Gets the pattern for dlls that we know don't need to be investigated.</summary>
        public string AssemblySkipLoadingPattern
        {
            get { return assemblySkipLoadingPattern; }
            set { assemblySkipLoadingPattern = value; }
        }

        /// <summary>Gets or sets the pattern for dll that will be investigated. For ease of use this defaults to match all but to increase performance you might want to configure a pattern that includes assemblies and your own.</summary>
        /// <remarks>If you change this so that Nop assemblies arn't investigated (e.g. by not including something like "^Nop|..." you may break core functionality.</remarks>
        public string AssemblyRestrictToLoadingPattern
        {
            get { return assemblyRestrictToLoadingPattern; }
            set { assemblyRestrictToLoadingPattern = value; }
        }

        #endregion

        #region Internal Attributed Assembly class

        private class AttributedAssembly
        {
            internal Assembly Assembly { get; set; }
            internal Type PluginAttributeType { get; set; }
        }

        #endregion

        #region ITypeFinder

        public IEnumerable<Type> FindClassesOfType<T>(bool onlyConcreteClasses = true)
        {
            return FindClassesOfType(typeof(T), onlyConcreteClasses);
        }

        public IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, bool onlyConcreteClasses = true)
        {
            return FindClassesOfType(assignTypeFrom, GetAssemblies(), onlyConcreteClasses);
        }

        public IEnumerable<Type> FindClassesOfType<T>(IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true)
        {
            return FindClassesOfType(typeof(T), assemblies, onlyConcreteClasses);
        }

        public IEnumerable<Type> FindClassesOfType(Type assignTypeFrom, IEnumerable<Assembly> assemblies, bool onlyConcreteClasses = true)
        {
            
            //// -See more at: https://weblogs.asp.net/ricardoperes/using-mef-in-net-core#sthash.q9t6fmJp.dpuf

            var assignTypeInfoFrom = assignTypeFrom.GetTypeInfo(); //to core modify
            var result = new List<Type>();
            try
            {
                foreach (var a in assemblies)
                {
                    Type[] types = null;
                    try
                    {
                        types = a.GetTypes();
                    }
                    catch
                    {
                    }
                    if (types != null)
                    {
                        foreach (var t in types)
                        {
                            var typeInfo = t.GetTypeInfo();
                            if (assignTypeFrom.IsAssignableFrom(t) || (assignTypeInfoFrom.IsGenericTypeDefinition && DoesTypeImplementOpenGeneric(t, assignTypeFrom)))
                            {
                                if (!typeInfo.IsInterface)
                                {
                                    if (onlyConcreteClasses)
                                    {
                                        if (typeInfo.IsClass && !typeInfo.IsAbstract)
                                        {
                                            result.Add(t);
                                        }
                                    }
                                    else
                                    {
                                        result.Add(t);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (ReflectionTypeLoadException ex)
            {
                var msg = string.Empty;
                foreach (var e in ex.LoaderExceptions)
                    msg += e.Message + Environment.NewLine;

                var fail = new Exception(msg, ex);
                Debug.WriteLine(fail.Message, fail);

                throw fail;
            }
            return result;
        }

        public IEnumerable<Type> FindClassesOfType<T, TAssemblyAttribute>(bool onlyConcreteClasses = true) where TAssemblyAttribute : Attribute
        {
            var found = FindAssembliesWithAttribute<TAssemblyAttribute>();
            return FindClassesOfType<T>(found, onlyConcreteClasses);
        }

        public IEnumerable<Assembly> FindAssembliesWithAttribute<T>()
        {
            return FindAssembliesWithAttribute<T>(GetAssemblies());
        }

        /// <summary>
        /// Caches attributed assembly information so they don't have to be re-read
        /// </summary>
        private readonly List<AttributedAssembly> _attributedAssemblies = new List<AttributedAssembly>();

        /// <summary>
        /// Caches the assembly attributes that have been searched for
        /// </summary>
        private readonly List<Type> _assemblyAttributesSearched = new List<Type>();

        public IEnumerable<Assembly> FindAssembliesWithAttribute<T>(IEnumerable<Assembly> assemblies)
        {
            //check if we've already searched this assembly);)
            if (!_assemblyAttributesSearched.Contains(typeof(T)))
            {
                var foundAssemblies = (from assembly in assemblies
                                       let customAttributes = assembly.GetCustomAttributes(typeof(T))//assembly.GetCustomAttributes(typeof(T), false) //to core modify
                                       where customAttributes.Any()
                                       select assembly).ToList();
                //now update the cache
                _assemblyAttributesSearched.Add(typeof(T));
                foreach (var a in foundAssemblies)
                {
                    _attributedAssemblies.Add(new AttributedAssembly { Assembly = a, PluginAttributeType = typeof(T) });
                }
            }

            //We must do a ToList() here because it is required to be serializable when using other app domains.
            return _attributedAssemblies
                .Where(x => x.PluginAttributeType.Equals(typeof(T)))
                .Select(x => x.Assembly)
                .ToList();
        }

        public IEnumerable<Assembly> FindAssembliesWithAttribute<T>(DirectoryInfo assemblyPath)
        {
            var assemblies = (from f in Directory.GetFiles(assemblyPath.FullName, "*.dll").Where(path => Matches(Path.GetFileName(path)))
                              select GetAssemblyByPath(f)//assemblyLoadContext.LoadFromAssemblyPath(f) //Assembly.LoadFrom(f) //to core modify
                                  into assembly
                              let customAttributes = assembly.GetCustomAttributes(typeof(T))//assembly.GetCustomAttributes(typeof(T), false)//to core modify
                              where customAttributes.Any()
                              select assembly).ToList();
            return FindAssembliesWithAttribute<T>(assemblies);
        }

        /// <summary>Gets tne assemblies related to the current implementation.</summary>
        /// <returns>A list of assemblies that should be loaded by the Nop factory.</returns>
        public virtual IList<Assembly> GetAssemblies()
        {
            var addedAssemblyNames = new List<string>();
            var assemblies = new List<Assembly>();
            AddAssembliesInAppDomain(addedAssemblyNames, assemblies); 
            return assemblies;
        }

        #endregion

        /// <summary>Iterates all assemblies in the AppDomain and if it's name matches the configured patterns add it to our list.</summary>
        /// <param name="addedAssemblyNames"></param>
        /// <param name="assemblies"></param>
        private void AddAssembliesInAppDomain(List<string> addedAssemblyNames, List<Assembly> assemblies)
        {
            //to core modify
            var dlls = Directory.GetFiles(AppContext.BaseDirectory, "*.dll").Where(path => Matches(Path.GetFileName(path)));
            
            foreach (var dll in dlls)
            {
                var assembly = GetAssemblyByPath(dll); 
                if (!addedAssemblyNames.Contains(assembly.FullName))
                {
                    assemblies.Add(assembly);
                    addedAssemblyNames.Add(assembly.FullName);
                }
            }
           
        }

        private Assembly GetAssemblyByPath(string path)
        {
            // If you pre-load the assembly by uncommenting this line, it works fine.
            // AssemblyLoadContext.Default.LoadFromAssemblyPath(assemblyPath);
            //see more :https://github.com/dotnet/corefx/issues/10365
            var assemblyName = AssemblyLoadContext.GetAssemblyName(path);
            AssemblyLoadContext.Default.Resolving += new Resolver(path).Resolving;
            return Assembly.Load(assemblyName);// Quits here with 'System.ExecutionEngineException'.
        }

        
        /// <summary>Check if a dll is one of the shipped dlls that we know don't need to be investigated.</summary>
        /// <param name="assemblyFullName">The name of the assembly to check.</param>
        /// <returns>True if the assembly should be loaded into Nop.</returns>
        public virtual bool Matches(string assemblyFullName)
        {
            return !Matches(assemblyFullName, AssemblySkipLoadingPattern)
                   && Matches(assemblyFullName, AssemblyRestrictToLoadingPattern);
        }

        /// <summary>Check if a dll is one of the shipped dlls that we know don't need to be investigated.</summary>
        /// <param name="assemblyFullName">The assembly name to match.</param>
        /// <param name="pattern">The regular expression pattern to match against the assembly name.</param>
        /// <returns>True if the pattern matches the assembly name.</returns>
        protected virtual bool Matches(string assemblyFullName, string pattern)
        {
            return Regex.IsMatch(assemblyFullName, pattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
        }

        
        protected virtual bool DoesTypeImplementOpenGeneric(Type type, Type openGeneric)
        {
            try
            {
                var genericTypeDefinitionInfo = openGeneric.GetGenericTypeDefinition().GetTypeInfo();//to core modify
                foreach (var implementedInterface in type.GetTypeInfo().FindInterfaces((objType, objCriteria) => true, null))
                {
                    if (!implementedInterface.GetTypeInfo().IsGenericType)
                    { continue; }

                    var isMatch = genericTypeDefinitionInfo.IsAssignableFrom(implementedInterface.GetGenericTypeDefinition());
                    return isMatch;
                }

                //if (openGeneric.IsClass)
                //{
                //    if (type.BaseType != null && type.BaseType.IsGenericType)
                //    {
                //        return genericTypeDefinition.IsAssignableFrom(type.BaseType.GetGenericTypeDefinition());
                //    }
                //}
                return false;
            }
            catch
            {
                return false;
            }
        }
        class Resolver
        {
            string resolvePath;
            AssemblyName resolveName;

            public Resolver(string assemblyPath)
            {
                resolveName = AssemblyLoadContext.GetAssemblyName(assemblyPath);
                resolvePath = assemblyPath;
            }

            public Assembly Resolving(AssemblyLoadContext context, AssemblyName assemblyName)
            {
                if (assemblyName.FullName == resolveName.FullName)
                {
                    var assembly = context.LoadFromAssemblyPath(resolvePath);
                    //Console.WriteLine("Resolving: " + Path.GetFileNameWithoutExtension(resolvePath) + " -> " + assembly);
                    return assembly;
                }

                return null;
            }
        }
    }
}
