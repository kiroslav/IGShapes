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
            int expectedAreaValue = 25;
            int actualAreaValue = testSquare.CalculateArea();

            Assert.AreEqual(expectedAreaValue, actualAreaValue);
        }

        [TestMethod]
        public void CalculateAreaIsNotEqual()
        {
            ShapesBasics.Square testSquare = new ShapesBasics.Square();
            testSquare.Length = 6;
            int expectedAreaValue = 25;
            int actualAreaValue = testSquare.CalculateArea();

            Assert.AreNotEqual(expectedAreaValue, actualAreaValue);
        }

        [TestMethod]
        public void DoTwoSquaresHaveEqualArea()
        {
            ShapesBasics.Square testSquare1 = new ShapesBasics.Square();
            testSquare1.Length = 5;

            ShapesBasics.Square testSquare2 = new ShapesBasics.Square();
            testSquare1.Length = 5;

            Assert.AreEqual(testSquare1, testSquare2);
        }
    }
}
