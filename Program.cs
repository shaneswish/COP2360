using System;

namespace DivisionExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            DivideStrings(input1, input2);
        }

        static void DivideStrings(string str1, string str2)
        {
            try
            {
                int num1 = Convert.ToInt32(str1);
                int num2 = Convert.ToInt32(str2);
                int result = num1 / num2;
                Console.WriteLine($"Result: {num1} / {num2} = {result}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: One or both inputs are not valid integers.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: One or both numbers are too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }
    }
}
