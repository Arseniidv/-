using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal amount = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        int currentMonth = 0;
        while (currentMonth < months)
        {
            amount *= 1.07m;
            currentMonth++;
        }

        Console.WriteLine($"Сумма через {months} месяцев: {amount:F2}");
    }
}