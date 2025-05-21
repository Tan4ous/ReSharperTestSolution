namespace ConsoleApp1;

public static class IfStatement
{
    public static void CheckNumberDivisors()
    {
        int ReadInput()
        {
            string s = Console.ReadLine();
            return int.Parse(s);
        }

        int n = ReadInput();
        bool result = (n % 2 == 0) && (n % 6 == 0);

        Console.WriteLine(result.ToString().ToLower());
    }
}