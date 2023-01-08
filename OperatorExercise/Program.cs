using System.Reflection.Metadata;
using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //declare a and b
            int a = 17;
            int b = 4;
            //add, subtract, multiply, and divide a and b.
            //find the remainder of a and b.
            int quotient = a % b;
            Console.WriteLine($"17 + 4 equals {a + b}.");
            Console.WriteLine($"17 - 4 equals {a - b}.");
            Console.WriteLine($"17 * 4 equals {a * b}.");
            Console.WriteLine($"17 / 4 equals {a / b} with a remainder of {quotient}.");
            //call area of circle method
            AreaOfCircle();


            // var is implicit type inferrence (more on this later)
            var i = 3;
            var j = 4;
            //i's value is incremented instantly, changing i to 4. j is still four.
            var k = ++i * j++;

            Console.WriteLine(k); // ouputs 16
        }




        public static void AreaOfCircle()
        {
            //prompt user for radius
            Console.WriteLine("What is the radius of the circle?");
            var radius = double.Parse(Console.ReadLine() );
            //calculate the area of a circle
            double area = Math.PI* Math.Pow(radius, 2);
            //print the area
            Console.WriteLine($"The area of a circle with a radius of {radius} is {area}.");
        }
    }
}
