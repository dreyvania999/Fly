using System;

namespace polet
{
    public class Program
    {
        public struct body
        {
            public double hm;
            public double h;
        }
        static body getHeight(double v, double t, double h1)
        {
            body telo = new body();
            double g = 9.81;
            double h = h1 + (v * v / g - g * Math.Pow(v / g, 2) / 2);
            telo.hm = h;
            h = h1 + (v * t - g * Math.Pow(t, 2) / 2);
            telo.h = h;
            return telo;

        }

        public static void Main(string[] args)
        {
            body telo = new body();
            Console.Write("Введите начальную скорость тела: ");
            double v = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите начальную высоту тела тела: ");
            double h1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("В какой момент времени происходит поиск высоты: ");
            double t = Convert.ToDouble(Console.ReadLine());
            telo = getHeight(v, t,h1);
            Console.WriteLine("Тело за " + t + "секунд достигнет высоты " + telo.h + "м");
            Console.WriteLine("Максимальная высота полёта тела равна " + telo.hm + "м");
        }
    }
}