using System;

namespace ArchitectArithmetic
{
    class Program
    {
        static double Rect(double length, double width)
        {
            return length * width;
        }

        static double Circle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        static double Triangle(double bottom, double height)
        {
            return 0.5 * bottom * height;
        }

        static double CalculateCost(double aera)
        {
            return Math.Round(aera * 180, 2);
        }

        public static void Main(string[] args)
        {

            double teotihuacamAera;
            double teotihuacanFloorCost;

            teotihuacamAera = Triangle(750, 500) + Rect(2500, 1500) + (Circle(375) / 2);
            teotihuacanFloorCost = CalculateCost(teotihuacamAera);
            Console.WriteLine($"The plan for the Teotihuacan costs {teotihuacanFloorCost} pesos");
            Console.ReadLine();

        }
    }
}


