using System;

namespace UserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.WriteLine("Whats your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine("How old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You are {age} years old!");
        }
    }
}
