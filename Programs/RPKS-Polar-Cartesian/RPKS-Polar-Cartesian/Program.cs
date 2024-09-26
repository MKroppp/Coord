using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPKS_Polar_Cartesian
{
    internal class Program
    {
        // Конвертация из декартовых координат в полярные
        static (double r, double theta) CartesianToPolar(double x, double y)
        {
            double r = Math.Sqrt(x * x + y * y);
            double theta = Math.Atan2(y, x);
            return (r, theta);
        }

        // Конвертация из полярных координат в декартовы
        static (double x, double y) PolarToCartesian(double r, double theta)
        {
            double x = r * Math.Cos(theta);
            double y = r * Math.Sin(theta);
            return (x, y);
        }
        static void Main(string[] args)
        {
            double x = 3, y = 12;
            var (r, theta) = CartesianToPolar(x, y);
            Console.WriteLine($"Декартовы координаты ({x}, {y}) в сферических: (r = {r}, theta = {theta})");

            var (newX, newY) = PolarToCartesian(r, theta);
            Console.WriteLine($"Сферические координаты (r = {r}, theta = {theta}) в декартовых: ({newX}, {newY})");
            Console.ReadLine();
        }
    }
}
