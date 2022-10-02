using System;

namespace Task1_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введіть число: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Ви ввели число {n}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error");
            }

        }
    }
}
