using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int height = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Trójkąt złożony ze znaków +:");

        int maxWidth = height * 2 - 1;
        int startOffset = (Console.WindowWidth - maxWidth) / 2;

        for (int row = 1; row <= height; row++)
        {
            int numSymbols = row * 2 - 1;
            int offset = (maxWidth - numSymbols) / 2;

            Console.SetCursorPosition(startOffset + offset, Console.CursorTop);
            Console.WriteLine(new string('+', numSymbols));
        }

        Console.ReadLine();
    }
}
