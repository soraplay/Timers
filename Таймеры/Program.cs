using System;
using System.Threading;

namespace Таймеры
{
    class Program
    {
        static Timer timer;

        static void Main(string[] args)
        {
            TimerCallback tc = new TimerCallback(Print);

            //timer = new Timer(tc, 5, 1000, 1000);

            TimerCallback tcObj = new TimerCallback(PrintObject);
            timer = new Timer(tcObj, new Point {X = 10, Y = 20 }, 1000, 1000);

            Console.Read();
        }

        public static void Print(object obj)
        {
            Random rnd = new Random();

            int n = rnd.Next(1, 5);
            Console.WriteLine(n);
            if (n == 3) timer.Dispose();
        }

        public static void PrintObject(object obj)
        {
            Point p = (Point)obj;
            Console.WriteLine(p.X + " " + p.Y);
        }
    }

    class Point
    {
        public int X;
        public int Y;
    }
}
