using System;
using System.Collections.Generic;
using System.IO;

namespace mini_project__1_shakespeare
{
    class Program
    {

        public static List<string> _list = new List<string>();
        public static string _line;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("pres 1 to run HeapSort , 2 Insertionsort, 3 Mergesort, 4 SelectionSort, 5 Trie");

            string selction = Console.ReadLine();

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
                    Console.WriteLine("Do Selection");
                    break;
                case "5":
                    Console.WriteLine("Do trie");
                    break;
                default:
                    Console.WriteLine("out of range");
                    break;
                    
            }

            Readfile();

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
                           
                            if (cword != null && word != "" && word !=" ")
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
