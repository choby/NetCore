using System.Collections;
using System.Collections.Generic;

namespace Kendo.Mvc.TagHelpers
{
    public abstract class TagHelperCollectionBase<T> : TagHelperChildBase, IList<T> where T : TagHelperCollectionItemBase
    {
        protected IList<T> InternalRef { get; set; }

        public TagHelperCollectionBase(IList<T> collection)
            :  base()
        {
            InternalRef = collection;
        }

        public T this[int index]
        {
            get
            {
                return InternalRef[index];
            }

            set
            {
                InternalRef[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return InternalRef.Count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return InternalRef.IsReadOnly;
            }
        }

        public void Add(T item)
        {
            InternalRef.Add(item);
        }

        public void Clear()
        {
            InternalRef.Clear();
        }

        public bool Contains(T item)
        {
            return InternalRef.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            InternalRef.CopyTo(array, arrayIndex);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return InternalRef.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            return InternalRef.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            InternalRef.Insert(index, item);
        }

        public bool Remove(T item)
        {
            return InternalRef.Remove(item);
        }

        public void RemoveAt(int index)
        {
            InternalRef.RemoveAt(index);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return InternalRef.GetEnumerator();
        }
    }
}
