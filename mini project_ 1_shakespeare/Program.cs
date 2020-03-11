using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Threading;

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

        public static void Main(string[] args)
        {

            Console.WriteLine("pres 1 to run HeapSort , 2 Insertionsort, 3 Mergesort, 4 SelectionSort, 5 Trie");
            string selction = Console.ReadLine();
            Readfile();
            Stopwatch stopwatch = new Stopwatch();


            switch (selction)
            {
                case "1":


                    
                    stopwatch.Start();
                    // is working
                    string[] _array = _list.ToArray();
                    string[] result1 = _heapSort.Sort(_array);

                    stopwatch.Stop();

                    for (int i = 0; i < result1.Length; i++)
                    {
                        Console.WriteLine(result1[i]);


                    }

                    TimeSpan ts = stopwatch.Elapsed;
                    string elapsedTime = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    Console.WriteLine("Heapsort " + elapsedTime);
                    stopwatch.Reset();
                    
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

                    stopwatch.Start();
                    // is working
                    string[] _array3 = _list.ToArray();
                    string[] result3 = _mergeSort.Sort(_array3);
                    stopwatch.Stop();

                    for (int i = 0; i < result3.Length; i++)
                    {
                        Console.WriteLine(result3[i]);
                    }

                    TimeSpan ts1 = stopwatch.Elapsed;
                    string elapsedTime1 = string.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts1.Hours, ts1.Minutes, ts1.Seconds,
                    ts1.Milliseconds / 10);
                    Console.WriteLine("MergeSort " + elapsedTime1);
                    stopwatch.Reset();


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

                    // / Does not print words out in console
                    string[] _array5 = _list.ToArray();

                    Console.WriteLine("arraycreatet");

                    for (int i = 0; i < _array5.Length; i++)
                    {
                                   _trieSort.insert(_array5[i], i);
                                   Console.WriteLine(_array5[i]);
                    }


                    foreach (var elements in _array5)
                    {
                        Console.WriteLine(elements);
                    }


                 //   string[] result5 = _trieSort.traversePreorder(_array5);

                    //foreach (var elements in _array5)
                    //{
                    //    Console.WriteLine(elements);
                    //}


                    //for (int i = 0; i < result5.Length; i++)

                    //{

                    //    Console.WriteLine(result5[i]);
                    //}

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


                        char[] charsToTrim = { ',', '.', ';', ':' };

                        foreach (string word in split)
                        {
                            string cword = word.Trim(charsToTrim);

                            if (cword != null && word != "" && word != " ")
                            {
                                _list.Add(cword);

                            }

                        }

                    }
                }

            }
            catch { }
        }
    }
}
