using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj wysokość trójkąta:");
        int wysokosc = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Trójkąt złożony ze znaków +:");

        int maxSzer = wysokosc * 2 - 1;
        int startOffset = (Console.WindowWidth - maxSzer) / 2;

        for (int row = 1; row <= wysokosc; row++)
        {
            int numSymbols = row * 2 - 1;
            int offset = (maxSzer - numSymbols) / 2;

            Console.SetCursorPosition(startOffset + offset, Console.CursorTop);
            Console.WriteLine(new string('+', numSymbols));
        }

        Console.ReadLine();
    }
}
