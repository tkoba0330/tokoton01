using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton01_4_Normal
{
    public static class A
    {
        public static Action Say = () => Console.WriteLine("My name is A!");

        public static void SayWait()
        {
            Say();
            Console.ReadLine();
        }

    }
}
