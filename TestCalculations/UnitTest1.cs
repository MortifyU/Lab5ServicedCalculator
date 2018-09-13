using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCalculations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var sum = calcRef.Add(4, 12);
            Assert.AreEqual(16, sum);
        }
        [TestMethod]
        public void TestSubtract()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var diff = calcRef.Subtract(4, 12);
            Assert.AreEqual(-8, diff);
        }
        [TestMethod]
        public void TestMultiply()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var times = calcRef.Multiply(4, 12);
            Assert.AreEqual(48, times);
        }
        [TestMethod]
        public void TestDivide()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var difference = calcRef.Divide(12, 4);
            Assert.AreEqual(3, difference);
        }
        [TestMethod]
        public void TestSquare()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var sqrt = calcRef.Square(9);
            Assert.AreEqual(3, sqrt);
        }
        [TestMethod]
        public void TestHalve()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var half = calcRef.Halve(12);
            Assert.AreEqual(6, half);
        }
        [TestMethod]
        public void TestQuarter()
        {
            var calcRef = new Calculator.CalculatorSoapClient();
            var fourth = calcRef.Quarter(12);
            Assert.AreEqual(3, fourth);
        }
    }
}
