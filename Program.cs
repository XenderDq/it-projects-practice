using System;

internal class Program
{
    private static void Main()
    {
        Console.Write("Введите сумму покупки: ");

        if (!decimal.TryParse(Console.ReadLine(), out decimal amount) || amount < 0)
        {
            Console.WriteLine("Введите неотрицательное число.");
            return;
        }

        decimal total = amount > 1500m ? amount * 0.90m : amount;
        Console.WriteLine($"Готово Итоговая сумма: {total:F2} руб.");
    }
}
