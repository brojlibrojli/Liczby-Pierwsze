using System;

namespace Liczby_Pierwsze
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wprowadz liczbe aby sprawdzic czy jest to liczba pierwsza:");
            int ile = int.Parse(Console.ReadLine());
            for (int i = 1; i < ile + 1; i++)
            {
                int v = int.Parse(Console.ReadLine());
                if (v == 2)
                {
                    Console.WriteLine("TAK");
                }
                if (v == 1)
                {
                    Console.WriteLine("NIE");
                }
                for (int j = 2; j < v; j++)
                {
                    if (v % j == 0)
                        Console.WriteLine("NIE");
                    break;
                }
                for (int j = 2; j < v; j++)
                {
                    if (v % j != 0)
                        Console.WriteLine("TAK");
                    break;
                }
            }
        }
    }
}