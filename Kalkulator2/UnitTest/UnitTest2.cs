using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class InputTest
    {
        // Testy czy metoda do wprowadzania danych przyjmuje znak ”1”-> {q1, 1ww, 11, w1e1}
        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("1", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”0”-> {q0, 0ww, 00, w0e0}
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("0", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”+” -> {+, 01+10, 0w1+e1q0}
        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("+", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”-” -> {-, 01-10, 0w1-e1q0}
        [TestMethod]
        public void TestKalkValueMinus()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("-", calc.CalcValue);
        }
    }
}
