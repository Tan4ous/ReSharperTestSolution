using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/iterators
    internal static class IteratorsTest
    {
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }

        public static IEnumerable<int> GetSetsOfNumbers()
        {
            int index = 0;
            while (index < 10)
                yield return index++;

            yield return 50;

            index = 100;
            while (index < 110)
                yield return index++;
        }

        public static IEnumerable<T> Sample<T>(this IEnumerable<T> sourceSequence, int interval)
        {
            int index = 0;
            foreach (T item in sourceSequence)
            {
                if (index++ % interval == 0)
                    yield return item;
            }
        }

        public static IEnumerable<int> GetSingleDigitOddNumbers(bool getCollection)
        {
            if (getCollection == false)
                return new int[0];
            else
                return IteratorMethod();
        }

        private static IEnumerable<int> IteratorMethod()
        {
            int index = 0;
            while (index < 10)
            {
                if (index % 2 == 1)
                    yield return index;
                index++;
            }
        }
    }
}
