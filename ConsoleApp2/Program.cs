using System;

namespace ConsoleApp2
{
    class Program
    {
        const int WEEK = 7;
        const int MIN_TEMP = 16;

        static void Main(string[] args)
        {
            int[] temps = new int[WEEK];
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            int i = 0;

            for (i=0; i<WEEK; i++)
            {
                Console.WriteLine($"Enter the temperature for {days[i]}");
                temps[i] = int.Parse(Console.ReadLine());
            }

            for (i=0; i<WEEK; i++)
            {
                if (temps[i] > MIN_TEMP)
                {
                    Console.Write($"{days[i]}, ");
                }
            }
            Console.ReadLine();

        }
    }
}
