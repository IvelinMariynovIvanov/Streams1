using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWritter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameToWrite = new string[] { "Ivelin ivanov", "Ralica Tsankova" };
            StreamWriter sw = new StreamWriter("C:/Users/ivelin/Documents/test.txt");

            using (sw)
            {
                foreach (var name in nameToWrite)
                {
                    sw.WriteLine(name);
                }
            }

            StreamReader sr = new StreamReader("C:/Users/ivelin/Documents/test.txt");
            string line;

            using (sr)
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
