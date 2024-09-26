using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPKS_Distance
{
    internal class Program
    {
        //Декартова система
        //Двумерное пространство
        static double d2(double x1, double x2, double y1, double y2)
        {
            double d = Math.Sqrt((x2-x1)*(x2 - x1)+ (y2 - y1) * (y2 - y1));
            return (d);
        }
        //Трехмерное пространство
        static double d3(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            double d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
            return (d);
        }

        //Полярная система
        //Двумерное пространство
        static double pd(double r1, double r2, double theta1, double theta2)
        {
            double d = Math.Sqrt(r1 * r1 + r2 * r2 - 2 * r1 * r2 * Math.Cos(theta2 - theta1));
            return (d);
        }

        //Сферическая система
        //Через объем сферы
        static double sd(double r1, double r2, double theta1, double theta2, double phi1, double phi2)
        {
            double d = Math.Sqrt(r1 * r1 + r2 * r2 - 2 * r1 * r2 * (Math.Sin(theta1) * Math.Sin(theta2) * Math.Cos(phi1 - phi2) + Math.Cos(theta1) * Math.Cos(theta2)));
            return (d);
        }

        //По поверхности сферы
        static double sd(double r, double theta1, double theta2, double phi1, double phi2)
        {
            double d = r * Math.Acos(Math.Sin(phi1) * Math.Sin(phi2) + Math.Cos(phi1) * Math.Cos(phi2) * Math.Cos(theta1 - theta2));
            return (d);
        }

        static void Main(string[] args)
        {
            double x1 = 3, x2 = 4, y1 = 7, y2 = 2;
            double d = d2(x1, x2, y1, y2);
            Console.WriteLine($"Прямое расстояние между двумя точками с координатами ({x1}, {y1}) и ({x2}, {y2}) в декартовой системе координат в двумерном пространстве: {d}");

            double z1 = 6, z2 = 5;
            d = d3(x1, x2, y1, y2, z1, z2);
            Console.WriteLine($"Прямое расстояние между двумя точками с координатами ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) в декартовой системе координат в трехмерном пространстве: {d}");

            double r1 = 5, r2 = 2, theta1 = Math.PI / 4, theta2 = Math.PI / 6;
            d = pd(r1, r2, theta1, theta2);
            Console.WriteLine($"Расстояние между точками в полярной системе координат в двумерном пространстве: {d}");

            double phi1 = Math.PI / 2, phi2 = 0;
            d = sd(r1, r2, theta1, theta2, phi1, phi2);
            Console.WriteLine($"Расстояние между точками в сферической системе координат через объем: {d}");

            double r = 7;
            d = sd(r, theta1, theta2, phi1, phi2);
            Console.WriteLine($"Расстояние между точками в сферической системе координат по поверхности сферы: {d}");

            Console.ReadLine();
        }
    }
}
