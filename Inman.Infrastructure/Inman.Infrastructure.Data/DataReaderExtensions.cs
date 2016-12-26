using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Inman.Infrastructure.Data
{
    public static class DataReaderExtensions
    {
        public static List<TType> DataReaderToObjectList<TType>(this IDataReader reader, string fieldsToSkip = null,
                                                                Dictionary<string, PropertyInfo> piList = null)
            where TType : new()
        {
            if (reader == null)
                return null;

            var items = new List<TType>();

            if (piList == null)
            {
                piList = new Dictionary<string, PropertyInfo>();
                var props = typeof(TType).GetTypeInfo().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (var prop in props)
                    piList.Add(prop.Name.ToLower(), prop);
            }

            while (reader.Read())
            {
                var inst = new TType();
                DataReaderToObject(reader, inst, fieldsToSkip, piList);
                items.Add(inst);
            }
            return items;
        }

        public static void DataReaderToObject(this IDataReader reader, object instance,
                                               string fieldsToSkip = null, Dictionary<string, PropertyInfo> piList = null)
        {
            if (reader.IsClosed)
                throw new InvalidOperationException("Data reader connot be used because it's already closed.");

            if (string.IsNullOrEmpty(fieldsToSkip))
                fieldsToSkip = string.Empty;
            else
                fieldsToSkip = "," + fieldsToSkip.Trim(',') + ",";

            fieldsToSkip = fieldsToSkip.ToLower();

            //create a dictionary of properties to look up
            //we can pass this in so we can cache the list once
            if (piList == null)
            {
                piList = new Dictionary<string, PropertyInfo>();
                var props = instance.GetType().GetTypeInfo().GetProperties(BindingFlags.Instance | BindingFlags.Public);
                foreach (var prop in props)
                    piList.Add(prop.Name.ToLower(), prop);
            }

            for (int index = 0; index < reader.FieldCount; index++)
            {
                string name = reader.GetName(index).ToLower();
                if (piList.ContainsKey(name))
                {
                    var prop = piList[name];
                    if (fieldsToSkip.Contains("," + name + ","))
                        continue;

                    if (prop != null && prop.CanWrite)
                    {
                        var val = reader.GetValue(index);
                        prop.SetValue(instance, (val == DBNull.Value) ? null : val, null);
                    }
                }
            }
            return;
        }
    }
}
