using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class OctInputTest
    {
        // Testy czy metoda do wprowadzania danych przyjmuje znak ”1”-> {q1, 1ww, 11, w1e1}
        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("1", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”0”-> {q0, 0ww, 00, w0e0}
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”+” -> {+, 01+10, 0w1+e1q0}
        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "+1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("1", calc.CalcValue);
        }

        //Testy czy metoda do wprowadzania danych przyjmuje znak ”-” -> {-, 01-10, 0w1-e1q0}
        [TestMethod]
        public void TestKalkValueMinus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("-1", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”2”
        [TestMethod]
        public void TestKalkValueTwos()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "2";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("2", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”3”
        [TestMethod]
        public void TestKalkValueThrees()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "3";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("3", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”4”
        [TestMethod]
        public void TestKalkValueFours()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "4";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("4", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”5”
        [TestMethod]
        public void TestKalkValueFives()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "5";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("5", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”6”
        [TestMethod]
        public void TestKalkValueSixes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "6";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("6", calc.CalcValue);
        }

        // Testy czy metoda do wprowadzania danych przyjmuje znak ”3”
        [TestMethod]
        public void TestKalkValueSevens()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "7";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("7", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreForbiddenNumbers()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "1021354109178"; //1021351091
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("10213541017", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "10A213D541CF09R1"; //1021354101
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("1021354101", calc.CalcValue);
        }
    }
}
