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
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i==0 || i == n - 1)
                    {
                        Console.Write("*");
                    }
                    else if(j==0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else { 
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
