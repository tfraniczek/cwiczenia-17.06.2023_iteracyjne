using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę n:");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pierwsze {0} liczby pierwsze:", n);

        int count = 0;
        int number = 2;

        while (count < n)
        {
            if (IsPrime(number))
            {
                Console.WriteLine(number);
                count++;
            }

            number++;
        }

        Console.ReadLine();
    }

    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
