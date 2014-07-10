using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
    public class Q
    {
        public static void Main(string[] args)
        {
            string a = "hello";
            string b = "goodbye";
            string c = b;
            b = b.Concat(a);

            Console.WriteLine("a = "+ a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

        }
    }
}
//There will be no output due to the b = b.conat(a);, which throws an error.