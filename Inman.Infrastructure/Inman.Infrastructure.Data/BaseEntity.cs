using System;


namespace Inman.Infrastructure.Data
{
    /// <summary>
    /// By Leo
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity : IEntity<int>
    {
        //protected BaseEntity()
        //{
        //    this.Enabled = (int)EnabledEnum.Enable;
        //}

        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public int CreatedCustomerId { get; set; }

        public DateTime ModifiedOn { get; set; }

        public string ModifiedBy { get; set; }

        public int ModifiedCustomerId { get; set; }

        public bool Deleted { get; set; }

        public int Enabled { get; set; }

        public int OwnerId { get; set; }

       

        //[NotMapped]
        //public EnabledEnum EnabledEnum
        //{
        //    get { return (EnabledEnum)this.Enabled; }
        //    set { this.Enabled = (int)value; }
        //}

        public int AccountID { get; set; }

        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        //public int Id { get; set; }
        //public override bool Equals(object obj)
        //{
        //    return Equals(obj as BaseEntity);
        //}

        //private static bool IsTransient(BaseEntity obj)
        //{
        //    return obj != null && Equals(obj.Id, default(int));
        //}

        //private Type GetUnproxiedType()
        //{
        //    return GetType();
        //}

        //public virtual bool Equals(BaseEntity other)
        //{
        //    if (other == null)
        //    { return false; }

        //    if (ReferenceEquals(this, other))
        //    { return true; }

        //    if (!IsTransient(this) &&
        //        !IsTransient(other) &&
        //        Equals(Id, other.Id))
        //    {
        //        var otherType = other.GetUnproxiedType();
        //        var thisType = GetUnproxiedType();
        //        return thisType.IsAssignableFrom(otherType) ||
        //                otherType.IsAssignableFrom(thisType);
        //    }

        //    return false;
        //}

        //public override int GetHashCode()
        //{
        //    if (Equals(Id, default(int)))
        //        return base.GetHashCode();
        //    return Id.GetHashCode();
        //}

        //public static bool operator ==(BaseEntity x, BaseEntity y)
        //{
        //    return Equals(x, y);
        //}

        //public static bool operator !=(BaseEntity x, BaseEntity y)
        //{
        //    return !(x == y);
        //}

        #region Code could be used for nHibernate

        //protected virtual void SetParent(dynamic child)
        //{

        //}
        //protected virtual void SetParentToNull(dynamic child)
        //{

        //}

        //protected void ChildCollectionSetter<T>(ICollection<T> collection, ICollection<T> newCollection) where T : class
        //{
        //    if (CommonHelper.OneToManyCollectionWrapperEnabled)
        //    {
        //        collection.Clear();
        //        if (newCollection != null)
        //            newCollection.ToList().ForEach(x => collection.Add(x));
        //    }
        //    else
        //    {
        //        collection = newCollection;
        //    }
        //}


        //protected ICollection<T> ChildCollectionGetter<T>(ref ICollection<T> collection, ref ICollection<T> wrappedCollection) where T : class
        //{
        //    return ChildCollectionGetter(ref collection, ref wrappedCollection, SetParent, SetParentToNull);
        //}

        //protected ICollection<T> ChildCollectionGetter<T>(ref ICollection<T> collection, ref ICollection<T> wrappedCollection, Action<dynamic> setParent, Action<dynamic> setParentToNull) where T : class
        //{
        //    if (CommonHelper.OneToManyCollectionWrapperEnabled)
        //        return wrappedCollection ?? (wrappedCollection = (collection ?? (collection = new List<T>())).SetupBeforeAndAfterActions(setParent, SetParentToNull));
        //    return collection ?? (collection = new List<T>());
        //}

        #endregion
    }
}
