using System;

namespace ControlWork
{
    public class Parabola
    {
        private float A { get; set; }
        private float B { get; set; }
        private float C { get; set; }
        private float X { get; set; }
        private float Y { get; set; }

        // Конструктор
        public Parabola(float a, float b, float c)
        {
            A = a;
            Console.WriteLine(a > 0 ? "Парабола направлена вверх" : "Парабола направлена вниз");
            B = b;
            C = c;
            X += GetX();
            Y += GetY();
        }

        private float GetX()
        {
            return -B / (2 * A);
        }

        private float GetY()
        {
            return (A * X * X) + (B * X) + C;
        }

        public void Output()
        {
            Console.WriteLine("A = {0}" +
                              "\nB = {1}" +
                              "\nC = {2}\n" +
                              "---------\n" +
                              "X = {3}" +
                              "\nY = {4}", A, B, C, X, Y);
        }

        // Деструктор
        ~Parabola()
        {
        }
    }
}