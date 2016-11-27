using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton01_3
{
    class A
    {
        public int MyFiled { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.MyFiled = 123;
            Console.WriteLine(a.MyFiled);
            System.Console.ReadLine();
        }
    }
}
