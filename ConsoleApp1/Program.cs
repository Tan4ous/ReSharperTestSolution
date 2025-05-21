namespace ConsoleApp1;
using System;

class MyClass
{
    // Getter-only auto-property
    public int MyValue => 42;
}

class Program
{
    // Field with initializer
    private int fieldInit = 5 + 5;

    // Property with initializer
    public string PropertyInit { get; set; } = "Auto" + "Prop";

    // Expression-bodied member
    public double Pi => 3.1415;

    static void Main()
    {
        // Lambda
        Action lambda = () =>
        {
            int a = 1;
            int b = 2;
            int sum = a + b;
            Console.WriteLine($"Lambda sum: {sum}");
        };

        // Switch
        int num = 4;
        string label = num switch
        {
            1 => "One",
            2 => "Two",
            3 => "Three",
            _ => "Other"
        };

        // Array
        int[] array = new int[] { 10, 20, 30 };

        // Object initialization
        var obj = new MyClass();

        // Code for extraction
        int x = 10;
        int y = 15;
        int result = x + y;
        Console.WriteLine($"Result: {result}");
    }
}