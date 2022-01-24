using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// Summary description for HexInputTest
    /// </summary>
    [TestClass]
    public class HexInputTest
    {
        [TestMethod]
        public void TestKalkValueZeros()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000000", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000001", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "2";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000002", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "3";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000003", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "4";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000004", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "5";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000005", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "6";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000006", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "8";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000008", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "9";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0000000000000009", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueA()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Aa";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000AA", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueB()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Bb";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000BB", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueC()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Cc";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000CC", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueD()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Dd";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000DD", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueE()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Ee";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000EE", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueF()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Ff";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("00000000000000FF", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreForbiddenLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "ALB1RY2IF"; //AB12F
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual("00000000000AB12F", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            //calc.ConvertSystem();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("FFFF", calc.CalcValue);
        }
    }
}
