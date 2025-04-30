using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Введите первое число (0-10): ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите второе число (0-10): ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0 || num1 > 10 || num2 < 0 || num2 > 10)
            {
                Console.WriteLine("Числа должны быть от 0 до 10! Попробуйте снова.\n");
            }
            else
            {
                Console.WriteLine($"Результат умножения: {num1 * num2}");
                break;
            }
        }
    }
}