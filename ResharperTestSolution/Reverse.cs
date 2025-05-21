namespace ResharperTestSolution;

public class Reverse
{
    public static void PrintReversed(string input)
    {
        var reversed = Reversed();
        Console.WriteLine(reversed);

        string Reversed()
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            var s = new string(chars);
            return s;
        }
    }
}