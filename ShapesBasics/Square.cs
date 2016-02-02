using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapesBasics
{
    public class Square
    {
        public double Length;
        const string Coppyright = "This shape is copyrighted by Infragistics, Inc";

        public double CalculateArea()
        {
            return Length * Length;
        }
    }

    public class Triangle
    {
        public double Height;
        public double Base;
        const string Coppyright = "This shape is copyrighted by Infragistics, Inc";

        public double CalculateArea()
        {
            return (Height * Base) / 2;
        }
    }

    public class Rectangle
    {
        public double SideA;
        public double SideB;
        const string Coppyright = "This shape is copyrighted by Infragistics, Inc";

        public double CalculateArea()
        {
            return SideA * SideB;
        }
    }
}
