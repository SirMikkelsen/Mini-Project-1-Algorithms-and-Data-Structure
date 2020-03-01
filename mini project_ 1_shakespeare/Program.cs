using System;
using System.Collections.Generic;
using System.IO;

namespace mini_project__1_shakespeare
{
    class Program
    {

        public List<string> _list = new List<string>();
        public string _line;
        
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }



        public void Readfile()
        {
            try
            {
                using (StreamReader sr = new StreamReader("shakespeare.txt"))
                {
                   
                  
                    while ((_line = sr.ReadLine()) != null)
                    {

                        string[] split = _line.Split(" ");

                        int i = 0;

                        string word;

                        char[] charsToTrim = { ',', '.', ';', ':' };

                        while (word = split[i].Trim(charsToTrim)) 
                        {
                            i++;

                        }
                        _list.Add(_line);
                        Console.WriteLine(_line);
                    }

                }

            }
            catch { }
        }
    }
}
