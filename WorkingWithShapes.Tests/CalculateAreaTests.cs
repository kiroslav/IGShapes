using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WorkingWithShapes.Tests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [TestMethod]
        public void CalculateArea()
        {
            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            testSquare.Length = 5;
            double expectedAreaValue = 25;
            double actualAreaValue = testSquare.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }

        [TestMethod]
        public void CalculateAreaIsNotEqual()
        {
            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            testSquare.Length = 6;
            double expectedAreaValue = 25;
            double actualAreaValue = testSquare.CalculateArea();

            Assert.AreNotEqual(expectedAreaValue, actualAreaValue);
        }

        //Test to check for BUG 1
        [TestMethod]
        public void CanCalculateDoubles()
        {
            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            testSquare.Length = 1.5;
            double expectedAreaValue = 2.25;
            double actualAreaValue = testSquare.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }
        //fixed 
        [TestMethod]
        public void DoTwoSquaresHaveEqualArea()
        {
            ShapesBasics.Square testSquare1 = new ShapesBasics.Square();
            testSquare1.Length = 5;
            double actualAreaValue = testSquare1.CalculateArea();

            ShapesBasics.Square testSquare2 = new ShapesBasics.Square();
            testSquare2.Length = 5;
            double actuualAreaValue2 = testSquare2.CalculateArea();

            Assert.AreEqual(actualAreaValue, actuualAreaValue2);
        }
        //Test Rectangle
        [TestMethod]
        public void CanCalculateRectangles()
        {
            ShapesBasics.Rectangle testRectangle = new ShapesBasics.Rectangle();
            testRectangle.SideA = 34;
            testRectangle.SideB = 11;
            double expectedAreaValue = 374;
            double actualAreaValue = testRectangle.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }
        //Test Triangles
        [TestMethod]
        public void CanCalculateTriangles()
        {
            ShapesBasics.Triangle testTriangle = new ShapesBasics.Triangle();
            testTriangle.Base = 34;
            testTriangle.Height = 11;
            double expectedAreaValue = 187;
            double actualAreaValue = testTriangle.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }
        //Test Triangles
        [TestMethod]
        public void CanCalculateTriangles2()
        {
            ShapesBasics.Triangle testTriangle = new ShapesBasics.Triangle();
            testTriangle.Base = 34.5;
            testTriangle.Height = 11;
            double expectedAreaValue = 189.75;
            double actualAreaValue = testTriangle.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }

        //Test Different shapes
        [TestMethod]
        public void CompareDifferentShapesEqual()
        {
            ShapesBasics.Triangle testTriangle = new ShapesBasics.Triangle();
            testTriangle.Base = 5;
            testTriangle.Height = 10;
            double expectedAreaValueTriangle = testTriangle.CalculateArea();

            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            testSquare.Length = 5;
            double actualValueSqare = testSquare.CalculateArea();

            Assert.AreEqual(expectedAreaValueTriangle, actualValueSqare);
        }

        //Test 10 000 shapes
        [TestMethod]
        public void CalculateTenThousandShapes()
        {
            ShapesBasics.Triangle testTriangle = new ShapesBasics.Triangle();
            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            ShapesBasics.Rectangle testRectangle = new ShapesBasics.Rectangle();
            Random rnd = new Random();
            double numbers = rnd.Next(1, 94);
            for (int i = 1; i <= 33333; i++ )
            {
                testTriangle.Base = rnd.Next(1, 90);
                testTriangle.Height = rnd.Next(1, 32);
                double expectValue = (testTriangle.Base * testTriangle.Height) / 2;
                double actualValue = testTriangle.CalculateArea();
                Assert.AreEqual(expectValue, actualValue);
            }
            for (int i = 1; i < 33333; i++)
            {
                testSquare.Length = rnd.Next(24, 90);
                double expectedValue = testSquare.Length * testSquare.Length;
                double actualValue = testSquare.CalculateArea();
                Assert.AreEqual(expectedValue, actualValue);
            }
            for (int i = 1; i < 33333; i++)
            {
                testRectangle.SideA = rnd.Next(1, 29);
                testRectangle.SideB = rnd.Next(1, 34);
                double expectedValue = testRectangle.SideB * testRectangle.SideA;
                double actualValue = testRectangle.CalculateArea();
                Assert.AreEqual(expectedValue, actualValue);
            }
        }

        //Test Possible Bugs with high numbers
        [TestMethod]
        public void PossibleBugsWithSigns()
        {
            ShapesBasics.Triangle testTriangle = new ShapesBasics.Triangle();
            testTriangle.Base = 34.5;
            testTriangle.Height = 999999999;
            double expectedAreaValue = 17249999982.75;
            double actualAreaValue = testTriangle.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }


    }
}
