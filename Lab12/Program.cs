using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            double rad;
            int choice;
            bool f = false;
            while (!f)
            {
                try
                {
                    Console.WriteLine("Введите значение радиуса");
                    rad = Convert.ToDouble(Console.ReadLine());
                    if (rad > 0)
                    {
                        Circle.Radius = rad;
                        f = true;
                    }
                    else
                    { Console.WriteLine("Значение радиуса может быть только положительным!"); }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine("Да, это значение подойдет");
            Console.WriteLine();
            Console.WriteLine("Что вы хотите вычислить?");
            Console.WriteLine("1. Длину окружности?");
            Console.WriteLine("2. Площадь круга?");
            Console.WriteLine("3. Принадлежит ли точка кругу?");
            Console.Write("Ваш выбор:");
            Console.WriteLine();
            try
            {
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        { Circle.LenghtCircle(); break; }
                    case 2:
                        { Circle.SquareCircle(); break; }
                    case 3:
                        {
                            double x; double y;         // координаты точки
                            double xС; double yС;   // координаты центра круга
                                Console.WriteLine("Введите координаты точки");
                                Console.Write("   x =  ");
                                x = Convert.ToDouble(Console.ReadLine());
                                Console.Write("   y =  ");
                                y = Convert.ToDouble(Console.ReadLine());
                                Console.WriteLine();
                                Console.WriteLine("Введите координаты центра круга");
                                Console.Write("   xС =  ");
                                xС = Convert.ToDouble(Console.ReadLine());
                                Console.Write("   yС =  ");
                                yС = Convert.ToDouble(Console.ReadLine());
                                Circle.Exist(x, y, xС, yС);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Будьте внимательны. Можно выбрать только 1,2 или 3");
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

        public static class Circle
        {
            public static double Radius;
            public static void LenghtCircle()
            {
                double lenght = 2 * Math.PI * Radius;
                Console.WriteLine("Длина окружности с радиусом {0} = {1,3:f2}", Radius, lenght);
            }
            public static void SquareCircle()
            {
                double square = Math.PI * Math.Pow(Radius, 2);
                Console.WriteLine("Площадь круга с радиусом {0} = {1,3:f2}", Radius, square);
            }

            public static void Exist(double x, double y, double xC, double yC)
            {
                double distance = Math.Sqrt(Math.Pow(x, 2) - Math.Pow(xC, 2) + (Math.Pow(y, 2) - Math.Pow(yC, 2)));
                if (distance > Radius)
                    Console.WriteLine($"Точка с координатами ({x},{y}) не принадлежит кругу, центр координат которого в точке ({xC},{yC}), а диаметр =  {Radius}");
                else
                    Console.WriteLine($"Точка с координатами ({x},{y}) принадлежит кругу, центр координат которого в точке ({xC},{yC}), а диаметр =  {Radius}");
            }

        }
    }
}
