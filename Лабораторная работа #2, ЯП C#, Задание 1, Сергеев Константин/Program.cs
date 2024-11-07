using System;

namespace MicrowaveSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            // вводим значение для поля isDoorOpen
            Console.WriteLine("Дверь микроволновки открыта? (введите true или false): ");
            bool isDoorOpen = BooleanInput();

            // вводим значение для поля isPoweredOn
            Console.WriteLine("Включена ли микроволновка? (введите true или false): ");
            bool isPoweredOn = BooleanInput();

            // вводим значение для уровня мощности
            Console.WriteLine("Введите уровень мощнеости микроволновки (от 1 до 10): ");
            int  powerLevel = Moshnost();

            // Создаём объект микроволновки с пользовательскими значениями
            MicrowaveChildClass microwave = new MicrowaveChildClass(isDoorOpen, isPoweredOn, powerLevel);

            // информация о текущем объекте
            Console.WriteLine("Информация о текущем объекте: ");
            Console.WriteLine(microwave.ToString());

            // проверка и автоматическое закрытие двери при необходимости
            microwave.AutoCloseDoor();

            // оптимизация уровня мощности
            microwave.OptimizePower();

            // повторный вывод информации после изменений
            Console.WriteLine("Информация на основе проверки двери и мощности микроволновой печи:");
            Console.WriteLine(microwave.ToString());

            // Создаём копию объекта
            Microwave microwaveCopya = new Microwave(microwave);

            // информация о копии объекта
            Console.WriteLine("Информация о копии объекта: ");
            Console.WriteLine(microwaveCopya.ToString());

            // Проверяем эквивалентность полей
            Console.WriteLine($"Эквивалентны ли поля? {microwave.EquivalentFields()}");
        }
        // метод для получения значения от пользователя (проверки)
        static bool BooleanInput()
        {
            while (true)
            {
                string input = Console.ReadLine().Trim().ToLower();
                if (input == "true")
                    return true;
                else if (input == "false")
                    return false;
                else if (input == "0")
                    return false;
                else if (input == "1")
                    return true;
                else if (input == "нет")
                    return false;
                else if (input == "да")
                    return true;
                else if (input == "no")
                    return false;
                else if (input == "yes")
                    return true;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите следующие значения -> true/false или да/нет, или 0/1: ");
            }
        }
        static int Moshnost()
        {
            while(true)
            {
                string input = Console.ReadLine().Trim();
                if (int.TryParse(input, out int result) && result >= 1 && result <= 10)
                    return result;
                else
                    Console.WriteLine("Некорректный ввод. Пожалуйста, введите число от 1 до 10: ");
            }
        }
    }
}