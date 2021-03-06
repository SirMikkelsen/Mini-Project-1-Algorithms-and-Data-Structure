﻿using System;
using System.Collections.Generic;
using System.Text;

namespace mini_project__1_shakespeare
{
    /// <summary>
    ///  Algorithm founded on the net
    /// </summary> big o is О(n2) 
    /// <typeparam name="T"></typeparam>
    public class SelectionSort<T> where T : IComparable
    {
        public T[] Sort(T[] list)
        {
            int k;
            T temp;

            for (int i = 0; i < list.Length; i++)
            {
                k = i;
                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j].CompareTo(list[k]) < 0)
                    {
                        k = j;
                    }
                }
                temp = list[i];
                list[i] = list[k];
                list[k] = temp;
            }

            return list;
        }

    }
}
