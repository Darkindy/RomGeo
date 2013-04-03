using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGeo.Utils
{
    public class OneBasedArray<T> : IEnumerable<T>
    {
        protected T[] elements;

        public OneBasedArray(int size)
        {
            elements = Enumerable.Repeat(default(T), size).ToArray();
        }

        public int Count
        {
            get { return elements.Length; }
        }

        public T this[int index]
        {
            get
            {
                if (index > 0 && index <= elements.Length)
                    return elements[index - 1];
                else throw new IndexOutOfRangeException("Attempted to get an element at an invalid index.");
            }
            set
            {
                if (index > 0 && index <= elements.Length) { elements[index - 1] = value; }
                else throw new IndexOutOfRangeException("Attempted to set an element at an invalid index.");
            }
        }

        #region ENUMERATORS-IMPLEMENTATION
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T t in elements) yield return t;
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        #endregion
    }
}
