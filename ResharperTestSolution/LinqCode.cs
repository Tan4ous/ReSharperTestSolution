using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResharperTestSolution
{
    //https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/walkthrough-writing-queries-linq
    internal class LinqCode
    {
        public static void DoLinq()
        {
            // The Three Parts of a LINQ Query:
            // 1. Data source.
            int[] numbers = [0, 1, 2, 3, 4, 5, 6];

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery = from num in numbers
                           where (num % 2) == 0
                           select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            var evenNumQuery = from num in numbers
                               where (num % 2) == 0
                               select num;

            int evenNumCount = evenNumQuery.Count();

            List<int> numQuery2 = (from num in numbers
                                   where (num % 2) == 0
                                   select num).ToList();

            // or like this:
            // numQuery3 is still an int[]

            var numQuery3 = (from num in numbers
                             where (num % 2) == 0
                             select num).ToArray();

            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            numbers = [1, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20];

            IEnumerable<int> queryFactorsOfFour = from num in numbers
                                                  where num % 4 == 0
                                                  select num;

            // Store the results in a new variable
            // without executing a foreach loop.
            var factorsofFourList = queryFactorsOfFour.ToList();

            // Read and write from the newly created list to demonstrate that it holds data.
            Console.WriteLine(factorsofFourList[2]);
            factorsofFourList[2] = 0;
            Console.WriteLine(factorsofFourList[2]);

            // Data source.
            int[] scores = [90, 71, 82, 93, 75, 82];

            // Query Expression.
            IEnumerable<int> scoreQuery = //query variable
                from score in scores //required
                where score > 80 // optional
                orderby score descending // optional
                select score; //must end with select or group

            // Execute the query to produce the results
            foreach (var testScore in scoreQuery)
            {
                Console.WriteLine(testScore);
            }

            // Output: 93 90 82 82

            numbers = [5, 10, 8, 3, 6, 12];

            //Query syntax:
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            //Method syntax:
            IEnumerable<int> numQuery4 = numbers
                .Where(num => num % 2 == 0)
                .OrderBy(n => n);

            foreach (int i in numQuery1)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(System.Environment.NewLine);
            foreach (int i in numQuery4)
            {
                Console.Write(i + " ");
            }


            numbers = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];

            // The query variables can also be implicitly typed by using var

            // Query #1.
            IEnumerable<int> filteringQuery =
                from num in numbers
                where num is < 3 or > 7
                select num;

            // Query #2.
            IEnumerable<int> orderingQuery =
                from num in numbers
                where num is < 3 or > 7
                orderby num ascending
                select num;

            // Query #3.
            string[] groupingQuery = ["carrots", "cabbage", "broccoli", "beans", "barley"];
            IEnumerable<IGrouping<char, string>> queryFoodGroups =
                from item in groupingQuery
                group item by item[0];

            List<int> numbers1 = [5, 4, 1, 3, 9, 8, 6, 7, 2, 0];
            List<int> numbers2 = [15, 14, 11, 13, 19, 18, 16, 17, 12, 10];

            // Query #4.
            double average = numbers1.Average();

            // Query #5.
            IEnumerable<int> concatenationQuery = numbers1.Concat(numbers2);

            // Query #6.
            IEnumerable<int> largeNumbersQuery = numbers2.Where(c => c > 15);

            // Query #7.

            // Using a query expression with method syntax
            var numCount1 = (
                from num in numbers1
                where num is > 3 and < 7
                select num
            ).Count();

            // Better: Create a new variable to store
            // the method call result
            IEnumerable<int> numbersQuery =
                from num in numbers1
                where num is > 3 and < 7
                select num;

            var numCount2 = numbersQuery.Count();
        }
    }
}
