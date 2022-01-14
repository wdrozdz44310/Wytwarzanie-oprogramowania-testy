using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class InputTestBin
    {
        // Testy czy metoda do wprowadzania danych przyjmuje znak ”1”-> {q1, 1ww, 11, w1e1}
        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "1";
            calc.ConvertSystem();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypQword, calc.CalcTyp);
            Assert.AreEqual("1", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”0”-> {q0, 0ww, 00, w0e0}
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "0";
            calc.ConvertSystem();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("0", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”+” -> {+, 01+10, 0w1+e1q0}
        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();
            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("+", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”-” -> {-, 01-10, 0w1-e1q0}
        [TestMethod]
        public void TestKalkValueMinus()
        {
            var calc = new Kalkulator.Calc();
            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("-", calc.CalcValue);
        }
    }
}
