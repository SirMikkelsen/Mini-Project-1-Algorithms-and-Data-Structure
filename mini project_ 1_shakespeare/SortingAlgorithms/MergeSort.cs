using System;
using System.Collections.Generic;
using System.Text;

namespace mini_project__1_shakespeare
{
    /// <summary>
    ///  Algorithm founded on the net
    /// </summary> big o is O (n log n)
    /// <typeparam name="T"></typeparam>
    public class MergeSort<T> where T : IComparable
    {

        // GO back 

        public static void Merge(T[] a, int lo, int mid, int hi)
        { // Merge a[lo..mid] with a[mid+1..hi].
            int i = lo, j = mid + 1;
            for (int k = lo; k <= hi; k++) // Copy a[lo..hi] to aux[lo..hi].
                aux[k] = a[k];
            for (int k = lo; k <= hi; k++) // Merge back to a[lo..hi].
                if (i > mid) a[k] = aux[j++];
                else if (j > hi) a[k] = aux[i++];
                else if (Less(aux[j], aux[i])) a[k] = aux[j++];
                else a[k] = aux[i++];
        }


        public static bool Less(T v, T w)
        {
            if (v.Equals(w)) return false;   // optimization when reference equals
            return v.CompareTo(w) < 0;
        }

        public static T[] aux; // auxiliary array for merges
        public T[] Sort(T[] a)
        {
            aux = new T[a.Length]; // Allocate space just once.
            sort(a, 0, a.Length - 1);

            return a;
        }
        public static void sort(T[] a, int lo, int hi)
        { // Sort a[lo..hi].
            if (hi <= lo) return;
            int mid = lo + (hi - lo) / 2;
            sort(a, lo, mid); // Sort left half.
            sort(a, mid + 1, hi); // Sort right half.
            Merge(a, lo, mid, hi);
        }
    }
}
