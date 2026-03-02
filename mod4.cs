using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {
            int result = DivideStrings(input1, input2);

            Console.WriteLine($"The result of {input1} divided by {input2} is: {result}");
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Error: One or both of the inputs are not valid integers.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("An unexpected error occurred.");
            Console.WriteLine($"Detailed error message: {ex.Message}");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static int DivideStrings(string a, string b)
    {
        int number1 = Convert.ToInt32(a);   // may throw FormatException[web:11]
        int number2 = Convert.ToInt32(b);   // may throw FormatException[web:11]
        return number1 / number2;
    }
}