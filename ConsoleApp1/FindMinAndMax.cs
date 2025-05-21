namespace ConsoleApp1;

public class FindMinAndMax
{
    public static int FindMin()
    {
        int[] InputValues(int valuesAmount)
        {
            int[] ints = new int[valuesAmount];

            if (Console.ReadLine() is string input)
            {
                string[] values = input.Split(' ');
                for (int i = 0; i < valuesAmount; i++)
                {
                    ints[i] = int.Parse(values[i]);
                }
            }

            return ints;
        }

        int valuesAmount = int.Parse((Console.ReadLine()));
        int[] inputValues = InputValues(valuesAmount);
        int min = inputValues.Min();
        return min;
    }

    public static string FindMaxAndMinOfThreeNumbers()
    {
        string result = "";

        int[] inputValues = ReadInput();
        int min = inputValues.Min();
        int max = inputValues.Max();

        result = ("min: " + min + ", max:" + max);

        return result;
    }

    public static int[] ReadInput()
    {
        int[] inputValues = new int[3];

        if (Console.ReadLine() is string input)
        {
            string[] values = input.Split(' ');
            for (int i = 0; i < 3; i++)
            {
                inputValues[i] = int.Parse(values[i]);
            }
        }

        return inputValues;
    }
}