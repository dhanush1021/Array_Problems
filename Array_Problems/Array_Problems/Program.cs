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
            List<int> list = new List<int>() {12,1,30,40,23,90,25,78,9};
            foreach (int i in list)
            {
                Console.Write($"{i} ");
            }
            list.Sort();
            Console.WriteLine();
            Console.WriteLine($"Minimum Element : {list[0]}");
            Console.WriteLine($"Maximum Element : {list[list.Count - 1]}");
        }
    }
}
