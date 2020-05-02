using System;

namespace BranchesAndLoops
{
    class Program
    {
        static void ExploreIf()
        {
            int a = 5;
            int b = 3;
            if (a + b > 10)
            {
                Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
            }

            int c = 4;
            if((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the firs number is not qual to the second");
            }

            if((a + b + c > 10) || (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("Or the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("And the first number is not equal to the second");
            }
        }

        static void ExploreWhile()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            }
        }

        static void ExploreDoWhile()
        {
            int counter = 0;
            do
            {
                Console.WriteLine($"Hello World! The counter is {counter}");
                counter++;
            } while (counter < 10);
        }

        static void ExploreFor()
        {
            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine($"Hello World! The index is {index}");
            }
        }

        static void SumOfIntegers(int range, int divider)
        {
            int sum = 0;
            for(int number = 1; number < range + 1; number ++)
            {
                if(number % divider == 0)
                    sum += number;
            }
            Console.WriteLine($"The sum of integers is {sum}");
        }

        static void Main(string[] args)
        {
            // ExploreIf();
            // ExploreWhile();
            // ExploreDoWhile();
            // ExploreFor();
            SumOfIntegers(6, 3);            
        }
    }
}
