using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            double first_number = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Результат: " + (first_number + 5));
            Console.WriteLine("Ошибка: Введите корректное число.");
        }
    }
}