using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program96
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите сумму кредита: ");
            if (!double.TryParse(Console.ReadLine(), out double amount) || amount <= 0)
            {
                Console.WriteLine("Ошибка: сумма должна быть положительным числом.");
                return;
            }

            Console.Write("Введите срок кредита (в годах): ");
            if (!double.TryParse(Console.ReadLine(), out double years) || years <= 0)
            {
                Console.WriteLine("Ошибка: срок должен быть положительным числом.");
                return;
            }

            double rate;
            if (years <= 1)
            {
                rate = 18.0;
            }
            else if (years <= 3)
            {
                rate = 15.0;
            }
            else
            {
                rate = 13.0;
            }

            Console.WriteLine($"Процентная ставка: {rate}% годовых (срок: {years} лет)");
        }
    }
}