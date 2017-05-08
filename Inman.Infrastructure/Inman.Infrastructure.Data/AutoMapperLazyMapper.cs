using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.Impl;
using AutoMapper.Internal;
using AutoMapper.Mappers;
using AutoMapper.QueryableExtensions;
using System.Linq.Expressions;
using System.Reflection;
using System.Linq;

namespace Inman.Infrastructure.Data
{
    public static class AutoMapperLazyMapper

    {
        private static readonly Func<LazyCreateMapAutoMapperConfigurator> _configurationInit =
          () =>
          {
              var platformSpecificRegistry = PlatformAdapter.Resolve<IPlatformSpecificMapperRegistry>();
              platformSpecificRegistry.Initialize();

              return new LazyCreateMapAutoMapperConfigurator(new TypeMapFactory(), MapperRegistry.Mappers, false);
          };

        private static ILazy<LazyCreateMapAutoMapperConfigurator> _configuration = LazyFactory.Create(_configurationInit);

        private static readonly Func<IMappingEngine> _mappingEngineInit = () => new MappingEngine(_configuration.Value);

        private static ILazy<IMappingEngine> _mappingEngine = LazyFactory.Create(_mappingEngineInit);

        private static LazyCreateMapAutoMapperConfigurator ConfigurationProvider
        {
            get
            {
                return _configuration.Value;
            }
        }

        /// <summary>
        /// Mapping engine used to perform mappings
        /// </summary>
        public static IMappingEngine Engine
        {
            get
            {
                return _mappingEngine.Value;
            }
        }

        public static Expression<Func<TSource, TDestination>> CreateMapExpression<TSource, TDestination>()
        {
            return Engine.CreateMapExpression<TSource, TDestination>();
        }

        public static IMappingExpression<TSource, TDestination> CreateLazyMap<TSource, TDestination>(Action<IMappingExpression<TSource, TDestination>> fun = null)
        {
            return ConfigurationProvider.CreateLazyMap(fun);
        }

        public static IMappingExpression<TSource, TDestination> CreateMap<TSource, TDestination>()
        {
            return ConfigurationProvider.CreateMap<TSource, TDestination>();
        }

        public static TDestination Map<TSource, TDestination>(TSource source)
        {
            return Engine.Map<TSource, TDestination>(source);
        }

        public static TDestination Map<TDestination>(object source)
        {
            return Engine.Map<TDestination>(source);
        }
        public static TDestination Map<TDestination>(object source, TDestination destination)
        {
            return Engine.Map(source, destination);
        }
    }

    public class LazyCreateMapAutoMapperConfigurator : ConfigurationStore, IConfigurationProvider
    {
        private bool _lazy;

        private Dictionary<TypePair, object> _mapCreatorsCache = new Dictionary<TypePair, object>();

        public LazyCreateMapAutoMapperConfigurator(ITypeMapFactory typeMapFactory, IEnumerable<IObjectMapper> mappers, bool lazy = true)
            : base(typeMapFactory, mappers)
        {
            this._lazy = lazy;
        }


        public TypeMap FindTypeMapFor(ResolutionResult resolutionResult, Type destinationType)
        {
            return this.FindTypeMapFor(resolutionResult.Value, null, resolutionResult.Type, destinationType) ??
                   this.FindTypeMapFor(resolutionResult.Value, null, resolutionResult.MemberType, destinationType);
        }

        public TypeMap FindTypeMapFor(Type sourceType, Type destinationType)
        {
            return this.FindTypeMapFor(null, null, sourceType, destinationType);
        }

        public TypeMap FindTypeMapFor(object source, object destination, Type sourceType, Type destinationType)
        {
            var typeMap = base.FindTypeMapFor(source, destination, sourceType, destinationType);

            if (typeMap != null)
            {
                return typeMap;
            }
            else
            {
                var typePair = new TypePair(sourceType, destinationType);
                if (_mapCreatorsCache.ContainsKey(typePair))
                {
                    var methods = typeof(LazyCreateMapAutoMapperConfigurator).GetMethods(BindingFlags.Public | BindingFlags.Instance);
                    var method = methods.FirstOrDefault(p =>
                    {
                        var genericArguments = p.GetGenericArguments();
                        if (p.Name != "CreateMap" || !p.IsGenericMethod || genericArguments.Length != 2
                            || p.GetParameters().Length != 0
                            || sourceType == null || destinationType == null)
                        {
                            return false;
                        }
                        return true;
                    });

                    var objMappingExpression = method.MakeGenericMethod(sourceType, destinationType).Invoke(this, null);
                    var objActionMappingExpression = _mapCreatorsCache[typePair];
                    if (objActionMappingExpression != null)
                    {
                        var tmpDelegate = objActionMappingExpression as Delegate;
                        tmpDelegate.DynamicInvoke(objMappingExpression);
                    }

                    return base.FindTypeMapFor(null, null, sourceType, destinationType);
                }
            }
            return null;
        }

        public IMappingExpression<TSource, TDestination> CreateLazyMap<TSource, TDestination>(Action<IMappingExpression<TSource, TDestination>> fun)
        {
            if (this._lazy)
            {
                var typePair = new TypePair(typeof(TSource), typeof(TDestination));
                _mapCreatorsCache[typePair] = fun;
                return null;
            }
            else
            {
                var result = this.CreateMap<TSource, TDestination>();
                if (fun != null)
                    fun(result);
                return result;
            }
        }
    }
}
