using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest
{
    /// <summary>
    /// Summary description for DecInputTest
    /// </summary>
    [TestClass]
    public class DecInputTest
    {
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000000", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "2";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000002", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "3";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000003", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "4";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000004", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "5";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000005", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "6";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000006", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "8";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000008", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "9";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000009", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "+325";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("0000000000000325", calc.CalcValue);
        }

        // TODO minus, ignorowanie znaków niedozwolonych
        [TestMethod]
        public void TestKalkValueIgnoreLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "an1t";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
        }
    }
}
