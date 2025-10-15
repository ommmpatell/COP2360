using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid whole numbers only.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Unexpected error: {ex.Message}");
        }

        Console.WriteLine("Program finished. Press any key to exit...");
        Console.ReadKey();
    }
}
