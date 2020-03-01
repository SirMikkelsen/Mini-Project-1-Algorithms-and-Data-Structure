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
            Console.WriteLine("Hello World!");

            Readfile();

            Console.ReadKey();
        }



        public static void Readfile()
        {
            try
            {
                Console.WriteLine("TEST");
                using (StreamReader sr = new StreamReader("shakespeare.txt"))
                {

                    while ((_line = sr.ReadLine()) != null)
                    {
                        
                        string[] split = _line.Split(" ");

                      

                        int i = 0;

                        string word;

                        char[] charsToTrim = { ',', '.', ';', ':' };

                        //while (word = split[i].Trim(charsToTrim)) 
                        //{
                        //    i++;

                        //}
                        //_list.Add(_line);
                        //Console.WriteLine(_line);
                    }

                }

            }
            catch { }
        }
    }
}
