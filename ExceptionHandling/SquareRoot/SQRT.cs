// Problem 1.	Square Root
// Write a program that reads an integer number and calculates and prints its square root.
// If the number is invalid or negative, print "Invalid number".
// In all cases finally print "Good bye". Use try-catch-finally.

namespace SquareRoot
{
    using System;

    public class SQRT
    {
        public static void Main()
        {
            Console.Write("Enter an integer number: ");

            try
            {
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new IndexOutOfRangeException("The number must be positive!");
                }

                double result = Math.Sqrt(number);

                Console.WriteLine("Square root of: {0} is {1}", number, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input!");
            }
            catch (IndexOutOfRangeException ix)
            {
                Console.WriteLine(ix.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("Invalid input! The number is too big or too small!");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
