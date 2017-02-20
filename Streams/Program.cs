using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader Sr = new StreamReader("C:/Users/ivelin/Documents/test.txt");

            string line;

            while ((line = Sr.ReadLine())!= null)
            {
                Console.WriteLine(line);
            }
        }
    }
}
