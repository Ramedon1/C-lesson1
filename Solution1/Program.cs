namespace Solution1;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первое число:");
        double first_number = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        double second_number = Convert.ToDouble(Console.ReadLine());

        if (second_number == 0 || first_number == 0)
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
        else
        {
            Console.WriteLine("Сумма: " + (first_number + second_number));
            Console.WriteLine("Разность: " + (first_number - second_number));
            Console.WriteLine("Произведение: " + (first_number * second_number));
            Console.WriteLine("Частное: " + (first_number / second_number));
        }
    }
}
