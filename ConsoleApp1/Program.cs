using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb1 = 0;
            int numb2 = 1;
            Console.WriteLine($"1: {numb1}");
            Console.WriteLine($"2: {numb2}");


            for (int i = 3; i < 41; i++)
            {
                numb2 += numb1;
                numb1 = numb2 - numb1;
                Console.WriteLine($"{i}: {numb2}");
            }
        }
    }
}
