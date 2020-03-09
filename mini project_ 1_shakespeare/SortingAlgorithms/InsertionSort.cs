using System;
using System.Collections.Generic;
using System.Text;

namespace mini_project__1_shakespeare
{
    /// <summary>
    ///  Algorithm founded on the net
    /// </summary>
    /// <typeparam name="T"></typeparam>


    public class InsertionSort<T> where T : IComparable
    {
        public T[] Sort(T[] array)
        {
            int i, j;

            for (i = 1; i < array.Length; i++)
            {
                T value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].CompareTo(value) > 0))
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = value;

            }

            return array;

        }

        //    public T[] Sort(T[] array)

        //    { // Sort a[] into increasing order.
        //        int N = array.Length;

        //        for (int i = 1; i < N; i++)
        //        { // Insert a[i] among a[i-1], a[i-2], a[i-3]... ..
        //            for (int j = i; j > 0 && Less(array[j], array[j - 1]); j--)
        //                Exch(array, j, j - 1);

        //        }

        //        return array;
        //    }

        //    public static bool Less(T v, T w)
        //    { return v.CompareTo(w) < 0; }


        //    public static void Exch(T[] a, int i, int j)
        //    { T t = a[i]; a[i] = a[j]; a[j] = t; }

        //}
    }
}
