using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomGeo.Utils
{
    /*
     * Using this wrapper class for arrays that need to be indexed from 1 instead of 0.
     * This way, question order, answer order and form elements names are not mismatched with their internal indexing.
     * 
     */


    public class OneBasedArray<T> : IEnumerable<T>
    {
        protected T[] elements;

        public OneBasedArray(int size)
        {
            elements = Enumerable.Repeat(default(T), size).ToArray();
        }

        public T this[int index]
        {
            get
            {
                if (index > 0 && index <= elements.Length)
                    return elements[index - 1];
                else throw new IndexOutOfRangeException((index == 0) ? "This one-based array wrapper enforces greater than 0 indexes." 
                                                                     : "Attempted to get an element at an invalid index.");
            }
            set
            {
                if (index > 0 && index <= elements.Length) { elements[index - 1] = value; }
                else throw new IndexOutOfRangeException((index == 0) ? "This one-based array wrapper enforces greater than 0 indexes." 
                                                                     : "Attempted to get an element at an invalid index.");
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
