using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Youtube_C_Sharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            string[] input = Console.ReadLine().Split();


            if (int.Parse(input[0]) > int.Parse(input[1]))
                Console.WriteLine(">");
            else if (int.Parse(input[0]) > int.Parse(input[1]))
                Console.WriteLine("<");
            else
                Console.WriteLine("=");
        }
    }
}
