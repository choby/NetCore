using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Inman.Infrastructure.Data;

namespace Inman.Infrastructure.EF
{
    public static class DbContextExtensions
    {
        #region Utilities

        private static T InnerGetCopy<T>(IDbContext context, T currentCopy,
                     Func<DbEntityEntry<T>, DbPropertyValues> func) where T : BaseEntity
        {
            DbContext dbContext = CastOrThrow(context);
          
            DbEntityEntry<T> entry = GetEntityOrReturnNull(currentCopy, dbContext);

            T output = null;

            if (entry != null)
            {
                DbPropertyValues dbPropertyValues = func(entry);
                if (dbPropertyValues != null)
                {
                    output = dbPropertyValues.ToObject() as T;
                }
            }

            return output;
        }


        private static DbEntityEntry<T> GetEntityOrReturnNull<T>(T currentCopy,
                                                                 DbContext dbContext) where T : BaseEntity
        {
            return dbContext.ChangeTracker.Entries<T>().FirstOrDefault(e => e.Entity == currentCopy);
        }

        private static DbContext CastOrThrow(IDbContext context)
        {
            DbContext output = (context as DbContext);
            if (output == null)
            {
                throw new InvalidOperationException("Context does not support operation.");
            }
            return output;
        }

        #endregion

        #region Methods

        public static T LoadOriginalCopy<T>(this IDbContext context,
                                            T currentCopy) where T : BaseEntity
        {
            return InnerGetCopy(context, currentCopy, e => e.OriginalValues);
        }

        public static T LoadDatabaseCopy<T>(this IDbContext context,
                                            T currentCopy) where T : BaseEntity
        {
            return InnerGetCopy(context, currentCopy, e => e.GetDatabaseValues());
        }

        public static void DropPluginTable(this DbContext context,
             string tableName)
        {
            if (context == null)
                throw new ArgumentNullException("context");

            if (String.IsNullOrEmpty(tableName))
                throw new ArgumentNullException("tableName");

            //drop the table
            if (context.Database.SqlQuery<int>("SELECT 1 FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = {0}", tableName).Any<int>())
            {
                var dbScript = "DROP TABLE [" + tableName + "]";
                context.Database.ExecuteSqlCommand(dbScript);
            }
            context.SaveChanges();
        }

        #endregion
    }
}
