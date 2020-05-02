using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int a, b, result;
            
            do{
            Console.Write("a = ");
            input = Console.ReadLine();
            if(input == "exit")
                break;
            a = Convert.ToInt32(input);

            Console.Write("b = ");
            b = Convert.ToInt32(Console.ReadLine());
            
            result = a + b;
            Console.WriteLine($"result = {result}");
            }while(true);
        }
    }
}
