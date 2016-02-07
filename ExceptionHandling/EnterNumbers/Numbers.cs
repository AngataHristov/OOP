// Problem 2.	Enter Numbers
// Write a method ReadNumber(int start, int end) that enters an integer number in given range[start…end]. 
// If an invalid number or non-number text is entered, the method should throw an exception.Using this method
// write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1< … < a10< 100.
// If the user enters an invalid number, let the user to enter again.

namespace EnterNumbers
{
    using System;

    public class Numbers
    {
        public static int ReadNumber(int start, int end, int previousNum)
        {
            int num = new int();

            try
            {
                num = int.Parse(Console.ReadLine());

                if (num < start || num > end)
                {
                    throw new ArgumentOutOfRangeException("The number is out of range");
                }
                if (num < previousNum)
                {
                    throw new InvalidOperationException("The number is smaller than previous number.Please try again with bigger one.");
                }
            }
            catch (ArgumentOutOfRangeException ae)
            {
                Console.WriteLine("{0} [{1}..{2}]!\n", ae.Message, start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error! Cannot convert this input to integer. Try again.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Input number is too big or too small to fit in int data type.Try again.");
            }
            catch (InvalidOperationException ie)
            {
                Console.WriteLine(ie.Message);
            }
            return num;
        }

        public static void Main()
        {
            const int start = 1;

            const int end = 100;

            Console.WriteLine("Enter 10 numbers, each next number should be bigger than previous in range [1 - 100]:");

            int num = new int();

            int previousNum = new int();

            for (int i = 0; i < 10; i++)
            {
                num = ReadNumber(start, end, previousNum);
                previousNum = num;
            }

            Console.WriteLine();
        }
    }
}
