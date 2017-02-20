using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Create
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Ivo", "Rali" };
            //FileStream fs = new FileStream("C:/Users/ivelin/Documents/newfile.txt", FileMode.OpenOrCreate, FileAccess.Write);

            //using (fs)
            //{
            //    byte[] newLine = new UTF8Encoding(true).GetBytes("\r\n");
            //    foreach (var item in names)
            //    {
            //        byte[] namesToBytes = new UTF8Encoding(true).GetBytes(item);
            //        fs.Write(namesToBytes, 0, namesToBytes.Length);
            //        fs.Write(newLine, 0, newLine.Length);

            //    }
            //}

            StreamWriter sw = new StreamWriter("C:/Users/ivelin/Documents/newfile.txt", true);

    //        using (sw)
  //          {
                foreach (var item in names)
                {
                    sw.WriteLine(item);
                }
//            }

            StreamReader sr = new StreamReader("C:/Users/ivelin/Documents/newfile.txt");
            string line = null;

            using (sr)
            {
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
            }

            //try
            //{
            //    StreamWriter sw;
            //    //sw operations
            //    sw.Flush();
            //    sw.Close();
            //}
            //catch ()
            //{
            //    //log error
            //}
            //finally
            //{
            //    if (sw != null)
            //    {
            //        sw.Flush();
            //        sw.Close();
            //    }
            //}


        }
    }
}
