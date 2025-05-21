#define VERBOSE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    internal class PreprocessorDirectivesCode
    {
        public static void DoPreprocessorDirectivesCode()
        {
#if DEBUG
            Console.WriteLine("Debug version");
#endif

#if !MYTEST
            Console.WriteLine("MYTEST is not defined");
#endif

#if (NET6_0_OR_GREATER || NETSTANDARD2_0_OR_GREATER)
            Console.WriteLine("Using .NET 6+ or .NET Standard 2+ code.");
#else
    Console.WriteLine("Using older code that doesn't support the above .NET versions.");
#endif



#if VERBOSE
            Console.WriteLine("Verbose output version");
#endif
        }
    }
}
