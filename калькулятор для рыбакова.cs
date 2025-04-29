using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("Простой калькулятор");

        while (true)
        {
            try
            {
                Console.Write("Введите первое число: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введите второе число: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Выберите операцию (+, -, *, /) или 'q' для выхода: ");
                string op = Console.ReadLine();

                if (op.ToLower() == "q") break;

                double result = Calculate(num1, num2, op);
                Console.WriteLine($"Результат: {result}\n");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Введите корректное число!\n");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль!\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}\n");
            }
        }
    }

    static double Calculate(double a, double b, string operation)
    {
        return operation switch
        {
            "+" => a + b,
            "-" => a - b,
            "*" => a * b,
            "/" => a / b,
            _ => throw new ArgumentException("Неподдерживаемая операция")
        };
    }
}