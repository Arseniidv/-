//задание с вкладавами 1
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < months; i++)
        {
            amount *= 1.07m; // Увеличиваем сумму на 7%
        }

        Console.WriteLine($"Сумма через {months} месяцев: {amount:F2}");
    }
}

