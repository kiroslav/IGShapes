using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WorkingWithShapes.CLI
{
    class Program
    {
        
        static void Main()
        {
            string choice = ChooseShape();
           //Square
            if (int.Parse(choice) == 1)
            {
               double area = SqareCalculate();
               double area2 = CompareAreas();
               Console.WriteLine("The areas of the two shapes are = " + area.ToString() +" and " + area2.ToString());
                if (area == area2)
                { Console.WriteLine("The areas are qual");}
                else
                { Console.WriteLine("The areas are different "); }
               Console.ReadLine();
            }
            //Triangle
            else if (int.Parse(choice)==2)
            {
              double area =  TriangleCalculate();
              double area2 = CompareAreas();
              Console.WriteLine("The areas of the two shapes are = " + area.ToString() + " and " + area2.ToString());
              if (area == area2)
              { Console.WriteLine("The areas are qual"); }
              else
              { Console.WriteLine("The areas are different "); }
              Console.ReadLine();
            }

            //Rectangle
            else if (int.Parse(choice) == 3)
            {
               double area =  RectangleCalculate();
               double area2 = CompareAreas();
               Console.WriteLine("The areas of the two shapes are = " + area.ToString() + " and " + area2.ToString());
               if (area == area2)
               { Console.WriteLine("The areas are qual"); }
               else
               { Console.WriteLine("The areas are different "); }
               Console.ReadLine();
            }
            
           
        }

        public static string ChooseShape()
        {
            Console.WriteLine("For area of square press \"1\", for triangle press \"2\", for rectangle press \"3\"");
            string choice = Console.ReadLine();
            int press;
            while (!int.TryParse(choice, out press))
            {
                Console.WriteLine("Please enter correct number");
                Console.WriteLine("For area of square press \"1\", for triangle press \"2\", for rectangle press \"3\"");
                choice = Console.ReadLine();
            }
            while (int.Parse(choice) > 3)
            {
                Console.WriteLine("Please enter correct number");
                Console.WriteLine("For area of square press \"1\", for triangle press \"2\", for rectangle press \"3\"");
                choice = Console.ReadLine();
            }
            while (int.Parse(choice) < 1)
            {
                Console.WriteLine("Please enter correct number");
                Console.WriteLine("For area of square press \"1\", for triangle press \"2\", for rectangle press \"3\"");
                choice = Console.ReadLine();
            }
            
            return choice;
        }

        public static double SqareCalculate()
        {
            Console.WriteLine("What is the lenght of the side ?");
            string side1 = Console.ReadLine();
            double value;
            while (!double.TryParse(side1, out value))
            {
                Console.WriteLine("Please enter number");
                Console.WriteLine("What is the lenght of the side ?");
                side1 = Console.ReadLine();
            }

            string[] sides = { side1 };
            Console.WriteLine("The length of the side is " + sides[0]);

            double shapeLength = double.Parse(sides[0]);
            ShapesBasics.Square mySquare = new ShapesBasics.Square();
            mySquare.Length = shapeLength;
            Console.WriteLine("The area is " + mySquare.CalculateArea().ToString());
            Console.ReadLine();
            return mySquare.CalculateArea();
        }

        public static double TriangleCalculate()
        {
            Console.WriteLine("What is the lenght of the base ?");
            string side1 = Console.ReadLine();
            double value;
            while (!double.TryParse(side1, out value))
            {
                Console.WriteLine("Please enter number");
                Console.WriteLine("What is the lenght of the base ?");
                side1 = Console.ReadLine();
            }
            Console.WriteLine("What is the lenght of the height ?");
            string side2 = Console.ReadLine();
            while (!double.TryParse(side2, out value))
            {
                Console.WriteLine("Please enter number");
                Console.WriteLine("What is the lenght of the height ?");
                side2 = Console.ReadLine();
            }

            string[] sides = { side1, side2 };

            double shapeBase = double.Parse(sides[0]);
            double shapeHeight = double.Parse(sides[1]);
            ShapesBasics.Triangle mySquare = new ShapesBasics.Triangle();
            mySquare.Base = shapeBase;
            mySquare.Height = shapeHeight;
            Console.WriteLine("The area is " + mySquare.CalculateArea().ToString());
            Console.ReadLine();
            return mySquare.CalculateArea();
        }

        public static double RectangleCalculate()
        {
            Console.WriteLine("What is the lenght of the side A ?");
            string side1 = Console.ReadLine();
            double value;
            while (!double.TryParse(side1, out value))
            {
                Console.WriteLine("Please enter number");
                Console.WriteLine("What is the lenght of the side A ?");
                side1 = Console.ReadLine();
            }
            Console.WriteLine("What is the lenght of the side B ?");
            string side2 = Console.ReadLine();
            while (!double.TryParse(side2, out value))
            {
                Console.WriteLine("Please enter number");
                Console.WriteLine("What is the lenght of the side B ?");
                side2 = Console.ReadLine();
            }

            string[] sides = { side1, side2 };

            double shapeSideA = double.Parse(sides[0]);
            double shapeSideB = double.Parse(sides[1]);
            ShapesBasics.Rectangle mySquare = new ShapesBasics.Rectangle();
            mySquare.SideA = shapeSideA;
            mySquare.SideB = shapeSideB;
            Console.WriteLine("The area is " + mySquare.CalculateArea().ToString());
            Console.ReadLine();
            return mySquare.CalculateArea();
        }

        public static double CompareAreas()
        {
            Console.WriteLine("Do you want to compare the result to other shape ? 1-Yes, any button-No");
            string side1 = Console.ReadLine();
          //  double value;
            double black = 1.22;
            if ((int.Parse(side1)) == 1)
            {
            string choice = ChooseShape();
            if (int.Parse(choice) == 1)
                     {
                     double area2 = SqareCalculate();
                     return area2;
                    }
                    else if (int.Parse(choice) == 2)
                    {
                     double area2 = TriangleCalculate();
                     return area2;
                    }
                    else if (int.Parse(choice) == 3)
                    {
                     double area2 = RectangleCalculate();
                     return area2;
                    }
            return black;
            }
            else
            {
           Console.WriteLine("Thank you");
           return black;
            }            
       }               
    }
}

