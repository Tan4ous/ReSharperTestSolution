static void PrintReversed(string input)
{
    var reversed = Reversed(input);
    Console.WriteLine(reversed);
}

static string Reversed(string input)
{
    var chars = input.ToCharArray();
    Array.Reverse(chars);
    var reversed = new string(chars);
    return reversed;
}