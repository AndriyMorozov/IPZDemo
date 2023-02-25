using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public static class Rectangle 
    {
        public static int Count;
        static Rectangle()
        {
            Count = 10;
            Console.WriteLine("Static constructor executed!");
        }
        public static void Rotate(int degree)
        {
           // ...
        }
    }
}
