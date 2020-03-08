using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace mini_project__1_shakespeare
{
    public class Program
    {
        public static HeapSort<string> _heapSort = new HeapSort<string>();
        public static InsertionSort<string> _insertionSort = new InsertionSort<string>();
        public static MergeSort<string> _mergeSort = new MergeSort<string>();
        public static SelectionSort<string> _selectionSort = new SelectionSort<string>();
        public static TrieSort<string> _trieSort = new TrieSort<string>();

        public static List<string> _list = new List<string>();
        public static string _line;
        public static int counter = 0;
        // public static string _srline;

        public static void Main(string[] args)
        {

            Console.WriteLine("pres 1 to run HeapSort , 2 Insertionsort, 3 Mergesort, 4 SelectionSort, 5 Trie");
            string selction = Console.ReadLine();
            Readfile();

            switch (selction)
            {
                case "1":

                    // is working
                    string[] _array = _list.ToArray();
                    string[] result1 = _heapSort.Sort(_array);

                    for (int i = 0; i < result1.Length; i++)
                    {
                        Console.WriteLine(result1[i]);
                    }
                    break;
                case "2":

                    // Does not print words out in console

                    string[] _array2 = _list.ToArray();
                    string[] result2 = _insertionSort.Sort(_array2);

                    for (int i = 0; i < result2.Length; i++)
                    {
                        Console.WriteLine(result2[i]);
                    }
                    break;

                case "3":

                    // is working

                    string[] _array3 = _list.ToArray();
                    string[] result3 = _mergeSort.Sort(_array3);

                    for (int i = 0; i < result3.Length; i++)
                    {
                        Console.WriteLine(result3[i]);
                    }

                    break;
                case "4":

                    // Does not print words out in console
                    string[] _array4 = _list.ToArray();
                    string[] result4 = _selectionSort.Sort(_array4);

                    for (int i = 0; i < result4.Length; i++)
                    {

                        Console.WriteLine(result4[i]);
                    }
                    break;
                case "5":

                    // prints words out in console but not in alphabetical order
                    string[] _array5 = _list.ToArray();
                    string[] result5 = _trieSort.Sort(_array5);
                    for (int i = 0; i < result5.Length; i++)

                    {
                        _trieSort.insert(_array5[i] ,i);
                        Console.WriteLine(result5[i]);
                    }

                    break;
                default:
                    Console.WriteLine("out of range");
                    break;

            }

            Console.ReadKey();
        }


        public static void Readfile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("../../../../shakespeare.txt"))
                {

                    while ((_line = sr.ReadLine()) != null)
                    {
                        string[] split = _line.Split(" ");
                        int i = 0;

                        char[] charsToTrim = { ',', '.', ';', ':' };

                        foreach (string word in split)
                        {
                            string cword = word.Trim(charsToTrim);

                            if (cword != null && word != "" && word != " ")
                            {
                                _list.Add(cword);

                            }

                            i++;

                        }

                    }
                }

            }
            catch { }
        }
    }
}
