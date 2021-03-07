using System;

namespace UserInput
{
    class Program
    {
        enum Operation {add, subtract, multiply, divide}

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Calculate!");
            Console.WriteLine("Type '?' if you need help. If you want to quit type \"quit\".");
            Console.WriteLine("Let's begin the game!");

            bool quit = false;
            string input, command, resStr;
            Random rnd = new Random();
            Operation opn;
            int rndValue, maxRnd = 10;
            double a, b, resNum = 0, ansNum = 0;

            do{
                Console.WriteLine("Calculate following expression:");
                rndValue = rnd.Next(Enum.GetNames(typeof(Operation)).Length);
                opn = (Operation) rndValue;

                switch(opn){
                    case Operation.add:
                        a = rnd.Next(maxRnd + 1);
                        b = rnd.Next(maxRnd + 1);
                        resNum = a + b;
                        Console.Write($"{a} + {b} = ");
                        break;
                    case Operation.subtract:
                        a = rnd.Next(maxRnd + 1);
                        b = rnd.Next(maxRnd + 1);
                        resNum = a - b;
                        Console.Write($"{a} - {b} = ");
                        break;
                    case Operation.multiply:
                        a = rnd.Next(maxRnd + 1);
                        b = rnd.Next(maxRnd + 1);
                        resNum = a * b;
                        Console.Write($"{a} * {b} = ");
                        break;
                    case Operation.divide:
                        a = rnd.Next(maxRnd + 1);
                        b = rnd.Next(1, maxRnd + 1);
                        resNum = a / b;
                        Console.Write($"{a} / {b} = ");
                        break;
                    default:
                        break;
                }
                //resStr = resNum.ToString();

                input = Console.ReadLine().Trim();
                command = input.ToLower();

                switch(command){
                    case "quit":
                        quit = true;
                        Console.WriteLine("Bye!");
                        break;
                    case "?":
                        Console.WriteLine("Here is help:");
                        Console.WriteLine("? - display help");
                        Console.WriteLine("quit - quit application");
                        break;
                    case "":
                        Console.WriteLine("Hm?...");
                        break;
                    default:
                        if(double.TryParse(command, out ansNum)){
                            if(resNum == ansNum)
                                Console.WriteLine("Exactly!");
                            else
                                Console.WriteLine($"Unfortunately wrong... The correct answer is {resNum}.");
                        }
                        else
                            Console.WriteLine($"I don't know that: \"{input}\".");
                        break;
                }
            }while(!quit);

        }
    }
}
