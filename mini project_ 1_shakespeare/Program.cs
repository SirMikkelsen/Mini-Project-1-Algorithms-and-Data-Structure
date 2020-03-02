using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace mini_project__1_shakespeare
{
    class Program
    {
       // public static ArrayList _list;
        public static string[] _list;
       //public static List<string> _list = new List<string>();
        public static string _line;
        public static string _srline;
        public static SelectionSort<string> _mySort = new SelectionSort<string>();
        
        
       // public static string[] _array = _list.ToArray();
        public static int counter = 0;


        static void Main(string[] args)
        {

            Console.WriteLine("pres 1 to run HeapSort , 2 Insertionsort, 3 Mergesort, 4 SelectionSort, 5 Trie");

            string selction = Console.ReadLine();


            Readfile();

            switch (selction)
            {
                case "1":
                    Console.WriteLine("Do heap");
                    break;
                case "2":
                    Console.WriteLine("Do Insertion");
                    break;
                case "3":
                    Console.WriteLine("Do Merge");
                    break;
                case "4":
                  

                    for (int i = 0; i <= 11; i++) 
                    {
                        Console.WriteLine(_list[i]);
                    }
                    //string[] result = _mySort.Sort(_list);
                    //Console.WriteLine(result.Length);
                    //for (int i = 0; i < result.Length; i++)
                    //{
                    //    Console.WriteLine("Test2");
                    //    Console.WriteLine(result[i]);
                    //}
                    Console.WriteLine("Tet3");
                    break;
                case "5":
                    Console.WriteLine("Do trie");
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

                using (StreamReader srcount = new StreamReader("../../../../shakespeare.txt"))
                {
                    while ((_srline = srcount.ReadLine()) != null)
                    {
                        string[] srsplit = _srline.Split(" ");
                        int i = 0;

                        char[] charsToTrim = { ',', '.', ';', ':' };

                        foreach (string srword in srsplit)
                        {
                            string srcword = srword.Trim(charsToTrim);


                            if (srcword != null && srcword != "" && srcword != " ")
                            {

                                counter++;
                            }

                            i++;
                        }

                    }


                }
                Array.Resize(ref _list, counter);
                Console.WriteLine(counter);

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
                                // _list.Add(cword);
                               _list[i] = cword; 

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
