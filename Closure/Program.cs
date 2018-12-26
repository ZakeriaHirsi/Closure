using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Closure
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> MyDelegate = GetFunc();


            Console.WriteLine(MyDelegate(5));
            Console.WriteLine(MyDelegate(6));
            Console.ReadLine();

        }
        
        private static Func<int,int> GetFunc()
        {
            int value1 = 1;

            Func<int, int> inc = delegate (int value2)
                 {
                     value1 = value1 + 1;
                     return value1 + value2;
                 };
            return inc;
        }
    }
}
