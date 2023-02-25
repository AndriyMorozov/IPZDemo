using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Point
    {
        public static int Count;
        public static void PrintData()
        {
            Count = 10;  
        }
        public double X { get; set; }
        public double Y { get; set; }
        static Point()
        {
            Count = 0;
            Console.WriteLine("Static constructor executed!");
        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Constructor executed!");
        } 
        public Point()
        {
            X = 0;
            Y = 0;
            Console.WriteLine("Default Constructor executed!");
        }
        public static bool operator ==(Point a, Point b)
        {
            return (a.X == b.X && a.Y == b.Y);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            return this == (Point)obj;
        }
        public static bool operator !=(Point a, Point b)
        {
            return !(a == b);
        }
        public static Point operator + (Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }
        public Point Add(Point a)
        {
            return new Point(this.X + a.X, this.Y + a.Y);
        }
        public static Point operator +(Point a, double b)
        {
            return new Point(a.X + b, a.Y);
        }
     
        public static Point operator +(double a, Point b)
        {
            return new Point(b.X + a, b.Y);
        } 

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }
}
