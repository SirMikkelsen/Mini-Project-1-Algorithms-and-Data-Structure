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
//                    Console.WriteLine(array[i]);              
                }

                array[j + 1] = value;
            }

            return array;
        }
    }
}
