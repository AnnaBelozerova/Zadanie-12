using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите радиус круга: ");
            Circle.Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату центра круга Х0: ");
            Circle.X0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату центра круга У0: ");
            Circle.Y0 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату точки Х: ");
            Circle.X = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату точки У: ");
            Circle.Y = Convert.ToDouble(Console.ReadLine());

            Circle.Length();
            Circle.Area();
            Circle.OnCircle();

            Console.ReadKey();
        }

        public class Circle
        {
            public static double Radius { get; set; }
            public static double X0 { get; set; }
            public static double Y0 { get; set; }
            public static double X { get; set; }
            public static double Y { get; set; }

            public static void Length()
            {
                Console.WriteLine("Длина окружности равна: {0:f2}", 2*Math.PI*Radius);
            }
            public static void Area()
            {
                Console.WriteLine("Площадь окружности равна: {0:f2}", Math.PI * Math.Pow(Radius,2));
            }
            public static void OnCircle()
            {
                if (Math.Sqrt(Math.Pow((X-X0),2)+ Math.Pow((Y - Y0), 2))<=Radius)
                {
                    Console.WriteLine("Точка принадлежит окружности");
                }
                else
                {
                    Console.WriteLine("Точка не принадлежит окружности");
                }
            }
        }

    }
}
