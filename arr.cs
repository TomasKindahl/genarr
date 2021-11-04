using System;
using System.Collections.Generic;
using System.Text;

namespace arr
{
    /// <summary>
    /// Generic array datatype
    /// </summary>
    /// <typeparam name="T">specific type</typeparam>
    public class Array<T>
    {
        T[] arr;
        //==== Constructors ====
        /// <summary>
        /// Constructor that allocates an array of elements with the
        /// </summary>
        /// <param name="size">desired size</param>
        /// <exception cref="ArgumentOutOfRangeException">if size ≤ 0</exception>
        public Array(int size)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("size must be greater than 0");
            arr = new T[size];
        }
        /// <summary>
        /// Constructor that takes a copy of an array datastruct
        /// </summary>
        /// <param name="raw">datastruct to copy</param>
        public Array(T[] raw) // Överkurs!
        {
            arr = (T[])raw.Clone();
        }
        /// <summary>
        /// Get the length of the Array
        /// </summary>
        /// <returns>the length</returns>
        public int Length()
        {
            return arr.Length;
        }
        // Access:
        /// <summary>
        /// Access element at certain index
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>the element at a certain index in the array</returns>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public T Get(int ix)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            return arr[ix];
        }
        /// <summary>
        /// Change element at a certain index to a new value
        /// </summary>
        /// <param name="ix">the index</param>
        /// <param name="val">the new value</param>
        /// <exception cref="IndexOutOfRangeException">if index &lt; 0 or Length() ≤ index</exception>
        public void Set(int ix, T val)
        {
            if (ix < 0)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            if (Length() <= ix)
                throw new IndexOutOfRangeException("index must be within range 0 to Length()");
            arr[ix] = val;
        }
        /// <summary>
        /// Indexed access of individual element
        /// </summary>
        /// <param name="ix">the index</param>
        /// <returns>get: returns the value at the index</returns>
        /// <returns>set: return nothing</returns>
        public T this[int ix]
        {
            get => Get(ix);
            set => Set(ix, value);
        }
        /// <summary>
        /// Constructs a string of the array
        /// <i>(Object.ToString override)</i>
        /// </summary>
        /// <returns>Returns the string</returns>
        public override string ToString()
        {
            string res = "{";
            Boolean first = true;
            foreach (T elt in arr)
            {
                if (first)
                    first = false;
                else
                    res += ", ";
                res += $"{elt}";
            }
            res += "}";
            return res;
        }
    }
}
