using System;
using Inman.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Inman.Infrastructure.EF
{
    public static class Extensions
    {
        public static Type GetUnproxiedEntityType(this BaseEntity entity)
        {
            var userType = DbContext.GetObjectType(entity.GetType());
            return userType;
        }

        public static  string getdaty()
        {

            return "";

        }


        
    }
}
