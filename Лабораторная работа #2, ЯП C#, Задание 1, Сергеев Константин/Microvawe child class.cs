using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace MicrowaveSpace
{
    public class MicrowaveChildClass : Microwave
    {
        // поле уровня мощности микроволновки
        private int powerLevel;

        // свойство для доступа к полю уровня мощности
        public int PowerLevel
        {
            get { return powerLevel; }
            set
            {
                if (!IsPoweredOn)
                {
                    Console.WriteLine("Чтобы выбрать мощность, нужно включить микроволновку. ");
                    return;
                }
                if (value >= 1 && value <= 10)
                    powerLevel = value;
                else
                    throw new ArgumentOutOfRangeException("Уровень мощности должен иметь значение от 1 до 10");
            }
        }
        // конструктор для инициализации состояния двери, питания и уровня мощности
        public MicrowaveChildClass(bool isDoorOpen, bool isPoweredOn, int powerLevel)
            : base(isDoorOpen, isPoweredOn)
        {
            this.PowerLevel = powerLevel;
        }

        // конструктор копировавания
        public MicrowaveChildClass(MicrowaveChildClass other)
            : base(other)
        {
            this.powerLevel = other.powerLevel;
        }
        // перегрузка метода ToString() для вывода информации об объекте.
        public override string ToString()
        {
            return $"{base.ToString()}, уровень мощности = {powerLevel}";
        }
        // метод для оптимизации мощности
        public void OptimizePower()
        {
            if (powerLevel >= 1 && powerLevel <= 3)
            {
                powerLevel = 5; // установка мощности в среднее значение
                Console.WriteLine("Мощность слишком низкая для оптимального разогрева пищи. Автоматически установлена мощность 5.");
            }
            else if (powerLevel >= 8 && powerLevel <= 10)
            {
                powerLevel = 6; // установка мощности в оптимильный диапозон
                Console.WriteLine("Мощность слишком высокая для разогрева пищи. Автоматически установлена мощность в оптимильный диапозон до 6.");
            }
            else if (!IsPoweredOn)
            {
                Console.WriteLine("Микроволновка выключена. Оптимизация уровня мощности невозможна");
                return;
            }
            else
            {
                Console.WriteLine("Мощность в оптимильном диапозоне.");
            }
        }

        // метод для автоматического закрытия двери микроволновки, если микроволновка работает.
        public void AutoCloseDoor()
        {
            if (IsDoorOpen && IsPoweredOn)
            {
                IsDoorOpen = false;
                Console.WriteLine("Внимание, дверь открыта при рабочей микроволновке. Дверь будет автоматически закрыта для безопасности. ");
            }
            else if (!IsPoweredOn)
            {
                Console.WriteLine("Микроволновка выключена. Автоматического закрытия двери не потребуется. ");
            }
            else
            {
                Console.WriteLine("Дверь уже закрыта. ");
            }
        }
    }
}