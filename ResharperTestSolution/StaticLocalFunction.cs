using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    internal class StaticLocalFunction
    {
        public static void A()
        {
            static void SubFunction()
            {
                Console.WriteLine("X");
                NewFunction();
            }
            Console.WriteLine("A");
            Console.WriteLine("B");
            Console.WriteLine("C");

            void NewFunction()
            {
                Console.WriteLine("Y");
                Console.WriteLine("Z");
            }
        }
    }
}