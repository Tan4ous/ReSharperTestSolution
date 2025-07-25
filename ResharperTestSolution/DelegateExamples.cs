﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/how-to-combine-delegates-multicast-delegates

    // Define a custom delegate that has a string parameter and returns void.
    delegate void CustomCallback(string s);

    internal class DelegateExamples
    {
        // Define two methods that have the same signature as CustomCallback.
        static void Hello(string s)
        {
            Console.WriteLine($"  Hello, {s}!");
        }

        static void Goodbye(string s)
        {
            Console.WriteLine($"  Goodbye, {s}!");
        }

        static void Main()
        {
            // Declare instances of the custom delegate.
            CustomCallback hiDel, byeDel, multiDel, multiMinusHiDel;

            // In this example, you can omit the custom delegate if you
            // want to and use Action<string> instead.
            //Action<string> hiDel, byeDel, multiDel, multiMinusHiDel;

            // Initialize the delegate object hiDel that references the
            // method Hello.
            hiDel = Hello;

            // Initialize the delegate object byeDel that references the
            // method Goodbye.
            byeDel = Goodbye;

            // The two delegates, hiDel and byeDel, are combined to
            // form multiDel.
            multiDel = hiDel + byeDel;

            // Remove hiDel from the multicast delegate, leaving byeDel,
            // which calls only the method Goodbye.
            multiMinusHiDel = (multiDel - hiDel)!;

            Console.WriteLine("Invoking delegate hiDel:");
            hiDel("A");
            Console.WriteLine("Invoking delegate byeDel:");
            byeDel("B");
            Console.WriteLine("Invoking delegate multiDel:");
            multiDel("C");
            Console.WriteLine("Invoking delegate multiMinusHiDel:");
            multiMinusHiDel("D");
        }
    }
    /* Output:
    Invoking delegate hiDel:
      Hello, A!
    Invoking delegate byeDel:
      Goodbye, B!
    Invoking delegate multiDel:
      Hello, C!
      Goodbye, C!
    Invoking delegate multiMinusHiDel:
      Goodbye, D!
    */
}
