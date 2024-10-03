using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPKS_Benchmark
{
    internal class Program
    {
        static Random rand = new Random();

        //Генерация координат для декартовой системы в двумерном пространстве
        static (double x, double y) GenerateCartesianPoint2D()
        {
            return (rand.NextDouble() * 100, rand.NextDouble() * 100);
        }

        //Генерация координат для декартовой системы в трехмерном пространстве
        static (double x, double y, double z) GenerateCartesianPoint3D()
        {
            return (rand.NextDouble() * 100, rand.NextDouble() * 100, rand.NextDouble() * 100);
        }

        //Генерация координат для полярной системы
        static (double r, double theta) GeneratePolarPoint()
        {
            double r = rand.NextDouble() * 100;
            double theta = rand.NextDouble() * 2 * Math.PI;
            return (r, theta);
        }

        //Генерация координат для сферической системы
        static (double r, double theta, double phi) GenerateSphericalPoint()
        {
            double r = rand.NextDouble() * 100;
            double theta = rand.NextDouble() * Math.PI;
            double phi = rand.NextDouble() * 2 * Math.PI;
            return (r, theta, phi);
        }

        //Расстояние между двумя точками в декартовой системе в двумерном пространстве
        static double DistanceCartesian2D((double x, double y) p1, (double x, double y) p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        }

        //Расстояние между двумя точками в декартовой системе в трехмерном пространстве
        static double DistanceCartesian3D((double x, double y, double z) p1, (double x, double y, double z) p2)
        {
            return Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2) + Math.Pow(p2.z - p1.z, 2));
        }

        //Расстояние между двумя точками в полярной системе
        static double DistancePolar((double r, double theta) p1, (double r, double theta) p2)
        {
            return Math.Sqrt(Math.Pow(p1.r, 2) + Math.Pow(p2.r, 2) - 2 * p1.r * p2.r * Math.Cos(p2.theta - p1.theta));
        }

        //Расстояние между двумя точками в сферической системе
        static double DistanceSpherical((double r, double theta, double phi) p1, (double r, double theta, double phi) p2)
        {
            return Math.Sqrt(Math.Pow(p1.r, 2) + Math.Pow(p2.r, 2) - 2 * p1.r * p2.r * (Math.Sin(p1.theta) * Math.Sin(p2.theta) * Math.Cos(p1.phi - p2.phi) + 
                Math.Cos(p1.theta) * Math.Cos(p2.theta)));
        }

        static void Main(string[] args)
        {
            int size = 100000;
            var cartesianPoints2d = new (double x, double y)[size];
            var cartesianPoints3d = new (double x, double y, double z)[size];
            var polarPoints = new (double r, double theta)[size];
            var sphericalPoints = new (double r, double theta, double phi)[size];

            for (int i = 0; i < size; i++)
            {
                cartesianPoints2d[i] = GenerateCartesianPoint2D();
                cartesianPoints3d[i] = GenerateCartesianPoint3D();
                polarPoints[i] = GeneratePolarPoint();
                sphericalPoints[i] = GenerateSphericalPoint();
            }

            //Измерение времени для декартовой системы в двумерном пространстве
            Stopwatch sw = Stopwatch.StartNew();
            for (int i = 0; i < size - 1; i++)
            {
                double dist = DistanceCartesian2D(cartesianPoints2d[i], cartesianPoints2d[i + 1]);
            }
            sw.Stop();
            Console.WriteLine($"Время декартова система в двумерном пространстве: {sw.ElapsedMilliseconds} мс");

            //Измерение времени для полярной системы
            sw.Restart();
            for (int i = 0; i < size - 1; i++)
            {
                double dist = DistancePolar(polarPoints[i], polarPoints[i + 1]);
            }
            sw.Stop();
            Console.WriteLine($"Время полярная система: {sw.ElapsedMilliseconds} мс");

            //Измерение времени для декартовой системы в трехмерном пространстве
            sw.Restart();
            for (int i = 0; i < size - 1; i++)
            {
                double dist = DistanceCartesian3D(cartesianPoints3d[i], cartesianPoints3d[i + 1]);
            }
            sw.Stop();
            Console.WriteLine($"Время декартова система в трехмерном пространстве: {sw.ElapsedMilliseconds} мс");

            //Измерение времени для сферической системы
            sw.Restart();
            for (int i = 0; i < size - 1; i++)
            {
                double dist = DistanceSpherical(sphericalPoints[i], sphericalPoints[i + 1]);
            }
            sw.Stop();
            Console.WriteLine($"Время сферическая система: {sw.ElapsedMilliseconds} мс");
            Console.ReadLine();
        }
    }
}
