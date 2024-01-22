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
            int m = 678736;
            int sum = 0;
            while(m > 0)
            {
                sum += m % 10;
                m /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
