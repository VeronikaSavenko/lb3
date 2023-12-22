using System;
using System.IO;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string way = @"D:\2k\lb3.2\photos\";
            try
            {
                string[] data = Directory.GetFiles(way);
                CurrentDirectory1.CurrentFiles(way, data);
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine($"Папку {way} не знайдено");
            }
            Console.ReadKey();
        }
    }
}
