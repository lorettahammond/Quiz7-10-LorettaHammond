using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x= 1789;
            evenOdd(x);
        }

        public static int evenOdd(int x)
        {
            if (x % 2 == 0)
            Console.WriteLine("Number is even.");
            else
            Console.WriteLine("Number is odd.");
            return 1;
        }
    }
}
