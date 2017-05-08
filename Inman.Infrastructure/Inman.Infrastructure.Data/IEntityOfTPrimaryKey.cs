using System;
using System.Collections.Generic;
using System.Text;

namespace Inman.Infrastructure.Data
{
    public interface IEntity<TPrimaryKey>
    {
        /// <summary>
        /// Unique identifier for this entity.
        /// </summary>
        TPrimaryKey Id { get; set; }
        bool Deleted { get; set; }

         DateTime CreatedOn { get; set; }

         string CreatedBy { get; set; }

         int CreatedCustomerId { get; set; }

         DateTime ModifiedOn { get; set; }

         string ModifiedBy { get; set; }

         int ModifiedCustomerId { get; set; }
         int Enabled { get; set; }
         int OwnerId { get; set; }
        /// <summary>
        /// Checks if this entity is transient (not persisted to database and it has not an <see cref="Id"/>).
        /// </summary>
        /// <returns>True, if this entity is transient</returns>
        //bool IsTransient();
    }
}
