using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tokoton01_4_Normal
{
    class Program
    {
        static void Main(string[] args)
        {
            A.Say = () => Console.WriteLine("My name is B");

            A.Say();

        }
    }
}
