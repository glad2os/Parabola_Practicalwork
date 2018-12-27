using System;

namespace ControlWork
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
             * TODO:
             * Написать класс Парабола y = ax2 + bx + c. Поля класса – коэффициенты a, b, c.
             * Реализовать функции: конструкторы (по умолчанию и инициализации),
             * свойства,  методы  вывода  уравнения  параболы  и  метод вычисления
             * экстремума функции (min или max): В классе Program продемонстрировать
             *  работу с объектом созданного класса.
             */
            Parabola Parabola = new Parabola(2, 1, 0);
            Parabola.Output();
        }
    }
}