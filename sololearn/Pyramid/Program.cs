using System;

namespace Pyramid
{
    class Program
    {
        static void DrawPyramid(int levels)
        {
            for(int i = 0; i < levels; i++)
            {
                for(int j = 1; j < levels - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 0; k < i * 2 - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            DrawPyramid(6);
        }
    }
}
