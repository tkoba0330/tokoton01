using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton01_2
{
    class A
    {
        private int myField;
        public int MyField
        {
            get
            {
                return myField;
            }
            set
            {
                myField = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.MyField = 123;
            Console.WriteLine(a.MyField);
            System.Console.ReadLine();
        }
    }
}
