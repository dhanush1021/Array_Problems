using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number to Print the pattern");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = n-1; i >= 0; i--)
            {
                for (int j = i; j >=0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
