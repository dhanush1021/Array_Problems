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
            List<int> list = new List<int>() {1,2,3,1,2,3,7,5,3,7,5,0,6,3,4 };
            list=list.Distinct().ToList();
            list.Sort();
            foreach (int i in list)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
