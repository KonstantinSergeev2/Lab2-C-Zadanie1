using System;

namespace MicrowaveSpace
{
    public class Microwave
    {
        // Логические поля для состояния двери и работы микроволновой печи
        private bool isDoorOpen;
        private bool isPoweredOn;
        // конструктор
        public Microwave(bool isDoorOpen, bool isPoweredOn)
        {
            this.isDoorOpen = isDoorOpen;
            this.isPoweredOn = isPoweredOn;
        }
        // свойства для доступа к полям IsDoorOpen и IsPoweredOn
        public bool IsDoorOpen
        {
            get { return isDoorOpen; }
            set { isDoorOpen = value; }
        }
        public bool IsPoweredOn
        {
            get { return isPoweredOn; }
            set { isPoweredOn = value; }
        }
        // конструктор копирования
        public Microwave(Microwave other)
        {
            this.isDoorOpen = other.IsDoorOpen;
            this.isPoweredOn = other.IsPoweredOn;
        }
        // метод для проверки эквивалентности полей
        public bool EquivalentFields()
        {
            return isDoorOpen == isPoweredOn;
        }
        // перегрузка метода ToString()
        public override string ToString()
        {
            return $"Статус микроволновки: Дверь открыта = {isDoorOpen}, Питание включено = {isPoweredOn}";
        }
    }
}