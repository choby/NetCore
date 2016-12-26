using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using Inman.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Inman.Infrastructure.EF
{
    public class BaseObjectContext : DbContext, IDbContext
    {
        public BaseObjectContext(DbContextOptions options)
            : base(options)
        {
        }

        //By Leo
        //protected virtual TEntity AttachEntityToContext<TEntity>(TEntity entity)
        //        where TEntity : BaseEntity, new()
        //{
        //    var alreadyAttached = Set<TEntity>().Local.FirstOrDefault(x => x.Id == entity.Id);
        //    if (alreadyAttached == null)
        //    {
        //        Set<TEntity>().Attach(entity);
        //        return entity;
        //    }
        //    else
        //    {
        //        return alreadyAttached;
        //    }

        //}

        //public string CreateDatabaseScript()
        //{
        //    return ((IObjectContextAdapter)this).ObjectContext.CreateDatabaseScript();
        //}

        public new DbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity, new()
        {
            return base.Set<TEntity>();
        }

        //public IList<TEntity> ExecuteStoredProcedureList<TEntity>(string commandText, params object[] parameters) where TEntity : class, new()
        //{
        //    bool hasOutputParameters = false;
        //    if (parameters != null)
        //    {
        //        foreach (var p in parameters)
        //        {
        //            var outputP = p as DbParameter;
        //            if (outputP == null)
        //                continue;

        //            if (outputP.Direction == ParameterDirection.InputOutput ||
        //                outputP.Direction == ParameterDirection.Output)
        //            { hasOutputParameters = true; }
        //        }
        //    }

        //    var context = ((IObjectContextAdapter)(this)).ObjectContext;
        //    if (!hasOutputParameters)
        //    {
        //        var result = this.Database.SqlQuery<TEntity>(commandText, parameters).ToList();
        //        //By Leo for (int i = 0; i < result.Count; i++)
        //        //    result[i] = AttachEntityToContext(result[i]);

        //        return result;
        //    }
        //    else
        //    {
        //        var connection = this.Database.Connection;
        //        bool conIsAlreadyOpen = true;
        //        try
        //        {
        //            if (connection.State == ConnectionState.Closed)
        //            {
        //                connection.Open();
        //                conIsAlreadyOpen = false;
        //            }
        //            using (var cmd = connection.CreateCommand())
        //            {
        //                cmd.CommandText = commandText;
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                if (parameters != null)
        //                    foreach (var p in parameters)
        //                        cmd.Parameters.Add(p);

        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    var result = context.Translate<TEntity>(reader).ToList();
        //                    //By Leo for (int i = 0; i < result.Count; i++)
        //                    //    result[i] = AttachEntityToContext(result[i]);

        //                    reader.Close();
        //                    return result;
        //                }

        //            }
        //        }
        //        finally
        //        {
        //            if (!conIsAlreadyOpen)
        //                connection.Close();
        //        }
        //    }
        //}

        //public IEnumerable<TElement> SqlQuery<TElement>(string sql, params object[] parameters)
        //{
        //    return this.Database.SqlQuery<TElement>(sql, parameters);
        //}

        //public int ExecuteSqlCommand(string sql, bool doNotEnsureTransaction = false, int? timeout = null, params object[] parameters)
        //{
        //    int? previousTimeout = null;
        //    if (timeout.HasValue)
        //    {
        //        previousTimeout = ((IObjectContextAdapter)this).ObjectContext.CommandTimeout;
        //        ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = timeout;
        //    }

        //    //var transactionalBehavior = doNotEnsureTransaction
        //    //                            ? TransactionalBehavior.DoNotEnsureTransaction
        //    //                            : TransactionalBehavior.EnsureTransaction;
        //    var result = this.Database.ExecuteSqlCommand(sql, parameters);
        //    if (timeout.HasValue)
        //    {
        //        ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = previousTimeout;
        //    }
        //    return result;
        //}

        //public new DatabaseFacade Database
        //{
        //    get { return base.Database; }
        //}
        //public DataTable ExecuteStoredProcedureDataTable(string commandText, params object[] parameters)
        //{
        //    var dataTable = new DataTable();
        //    using (var command = this.Database.Connection.CreateCommand())
        //    {
        //        command.CommandText = commandText;
        //        command.CommandType = CommandType.StoredProcedure;
        //        command.Parameters.AddRange(parameters);

        //        SqlDataAdapter adapter = new SqlDataAdapter(command as SqlCommand);
        //        adapter.Fill(dataTable);
        //    }
        //    return dataTable;
        //}

        //public DataTable ExecuteSqlDataTable(string commandText, params object[] parameters)
        //{
        //    var dataTable = new DataTable();
        //    using (var command = this.Database.Connection.CreateCommand())
        //    {
        //        command.CommandText = commandText;
        //        command.CommandType = CommandType.Text;
        //        command.Parameters.AddRange(parameters);

        //        SqlDataAdapter adapter = new SqlDataAdapter(command as SqlCommand);
        //        adapter.Fill(dataTable);
        //    }
        //    return dataTable;
        //}
    }
}
