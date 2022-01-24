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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
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
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
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
            //calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000177777", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000002", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000003", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000004", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000005", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000006", calc.CalcValue);
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
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000007", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreForbiddenNumbers()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "1021354109178"; //1021351091
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            // calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("0000010213541017", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "10A213D541CF09R1"; //1021354101
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.SignValidation();
            // calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemOct, calc.CalcSystem);
            Assert.AreEqual("0000001021354101", calc.CalcValue);
        }
    }
}
