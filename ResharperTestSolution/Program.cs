// See https://aka.ms/new-console-template for more information
using ResharperTestSolution;
using System.Reflection;

#region String interpolation using $
var name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.
#endregion


#region Reflection (https://learn.microsoft.com/en-us/dotnet/csharp/advanced-topics/reflection-and-attributes/how-to-query-assembly-metadata-with-reflection-linq)
Assembly assembly = Assembly.Load("System.Private.CoreLib, Version=7.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e");
var pubTypesQuery = from type in assembly.GetTypes()
                    where type.IsPublic
                    from method in type.GetMethods()
                    where method.ReturnType.IsArray == true
                        || (method.ReturnType.GetInterface(
                            typeof(System.Collections.Generic.IEnumerable<>).FullName!) != null
                        && method.ReturnType.FullName != "System.String")
                    group method.ToString() by type.ToString();

foreach (var groupOfMethods in pubTypesQuery)
{
    Console.WriteLine($"Type: {groupOfMethods.Key}");
    foreach (var method in groupOfMethods)
    {
        Console.WriteLine($"  {method}");
    }
}
#endregion

