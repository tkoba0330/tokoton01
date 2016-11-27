using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton01_Singleton
{
    static class A
    {
        internal static int B;
    }


    class Program
    {
        static void Main(string[] args)
        {
            A.B = 123;
            Console.WriteLine(A.B);

            A.B = 456;
            Console.WriteLine(A.B);

            Console.ReadLine();
        }
    }
}
