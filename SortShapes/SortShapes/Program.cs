using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace SortShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("shapes.txt");

            List<Shape> list = new List<Shape>();
            foreach (string line in lines)
            {
                if(calculateArea(line) != -1)
                {
                    list.Add(new Shape(line.Split(" ")[0], calculateArea(line)));
                }
                    
            }

            list.Sort((x, y) => y.getSize().CompareTo(x.getSize()));
            foreach(Shape line in list)
            {
                Console.WriteLine(line.getShape() + " " + line.getSize());
            }
        }

        public static double calculateArea(string line)
        {
            if (line == null || line.Length == 0)
                return -1;

            string[] arr = line.Split(" ");
            double area = 0.0;
            switch(arr[0])
            {
                case "circle":
                    area = calculateCircle(double.Parse(arr[1]));
                    break;
                case "rectangle":
                    area = calculateRectangle(double.Parse(arr[1]), double.Parse(arr[2]));
                    break;
                case "square":
                    area = calculateSquare(double.Parse(arr[1]));
                    break;
                case "triangle":
                    area = calculateTriangle(double.Parse(arr[1]), double.Parse(arr[2]));
                    break;
                default:
                    area = -1;
                    break;
            }
            return area;
        }

        public static double calculateCircle(double diameter)
        {
            if (diameter <= 0)
                return -1;

            return Math.PI * Math.Pow((diameter / 2), 2);
        }

        public static double calculateSquare(double width)
        {
            if (width <= 0)
                return -1;

            return Math.Pow(width, 2);
        }

        public static double calculateRectangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                return -1;

            return width * height;
        }

        public static double calculateTriangle(double width, double height)
        {
            if (width <= 0 || height <= 0)
                return -1;

            return (width * height) / 2;
        }
    }
}
