using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Inman.Infrastructure.Data;

namespace Inman.Infrastructure.EF
{
    public class SqlServerDataProvider : IDataProvider
    {
        #region Utilities

        protected virtual string[] ParseCommands(string filepath, bool throwExceptionIfNotExists)
        {
            if (!File.Exists(filepath))
            {
                if (throwExceptionIfNotExists)
                    throw new ArgumentException(string.Format("Specified file doesn't exist - {0}", filepath));
                else
                    return new string[0];
            }
            var statements = new List<string>();
            using (var stream = File.OpenRead(filepath))
            using (var reader = new StreamReader(stream))
            {
                var statement = "";
                while ((statement = ReadNextStatementFromStream(reader)) != null)
                {
                    statements.Add(statement);
                }
            }
            return statements.ToArray();
        }

        protected virtual string ReadNextStatementFromStream(StreamReader reader)
        {
            var sb = new StringBuilder();

            while (true)
            {
                string lineOfText = reader.ReadLine();
                if (lineOfText == null)
                {
                    if (sb.Length > 0)
                        return sb.ToString();
                    else
                        return null;
                }
                if (lineOfText.TrimEnd().ToUpper() == "GO")
                    break;

                sb.Append(lineOfText + Environment.NewLine);
            }
            return sb.ToString();
        }

        #endregion

        public void InitConnectionFactory()
        {
            var connectionFactory = new SqlConnectionFactory();
            Database.DefaultConnectionFactory = connectionFactory;
        }

        public void InitDatabase()
        {
            InitConnectionFactory();
            //SetDatabaseInitializer();
        }

        public void SetDatabaseInitializer()
        {
            var tablesToValidate = new[] { "Customer", "Discount", "Order", "Product", "ShoppingCartItem" };
            var customCommands = new List<string>();
            //use webHelper.MapPath instead of HostingEnvironment.MapPath which is not available in unit tests
            customCommands.AddRange(ParseCommands(HostingEnvironment.MapPath("~/App_Data/SqlServer.Indexes.sql"), false));
            //use webHelper.MapPath instead of HostingEnvironment.MapPath which is not available in unit tests
            customCommands.AddRange(ParseCommands(HostingEnvironment.MapPath("~/App_Data/SqlServer.StoredProcedures.sql"), false));

        }

        public bool StoredProceduredSupported
        {
            get { return true; }
        }

        public DbParameter GetParameter()
        {
            return new SqlParameter();
        }
    }
}
