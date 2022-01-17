using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class BinInputTest
    {
        // Testy czy metoda do wprowadzania danych przyjmuje znak ”1”-> {q1, 1ww, 11, w1e1}
        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”0”-> {q0, 0ww, 00, w0e0}
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000000", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”+” -> {+, 01+10, 0w1+e1q0}
        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "+1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”-” -> {-, 01-10, 0w1-e1q0}
        [TestMethod]
        public void TestKalkValueMinus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("1111111111111111", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreForbiddenNumbers()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "1021354109178"; //101101
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("0000000000101101", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "10A1BCD10E1FGHJ"; //101101
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemBin, calc.CalcSystem);
            Assert.AreEqual("0000000000101101", calc.CalcValue);
        }
    }
}
