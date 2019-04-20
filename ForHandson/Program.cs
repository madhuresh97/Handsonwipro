using System;

namespace ForHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            double side, area;
            Console.WriteLine("Enter the side of square: ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("The area of square is: " + area);
        }
    }
}
