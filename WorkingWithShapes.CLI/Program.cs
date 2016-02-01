using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithShapes.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The length of the side is " + args[0]);
            int shapeLength = int.Parse(args[0]);
            ShapesBasics.Square mySquare = new ShapesBasics.Square();
            mySquare.Length = shapeLength;
            Console.WriteLine("The area is " + mySquare.CalculateArea().ToString());
        }
    }
}
