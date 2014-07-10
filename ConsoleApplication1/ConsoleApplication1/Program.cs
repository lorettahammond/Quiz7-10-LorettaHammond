using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main (string[] args)

        {
            int x = 5, y = 15;
            myfunc(x, y);
        }

    public static void myfunc(int x, int y)
    {
         Console.WriteLine(x * y);
            
    }
    }
}
