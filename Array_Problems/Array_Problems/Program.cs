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
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string[] list = str.Split(' ');
            Array.Reverse(list);
            string strrev = string.Join(" ", list);
            Console.WriteLine(strrev);
        }
    }
}
