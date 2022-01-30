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
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "2";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("2", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "3";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("3", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "4";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("4", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "5";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("5", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "6";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("6", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "8";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("8", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "9";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("9", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueA()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Aa";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("AA", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueB()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Bb";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("BB", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueC()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Cc";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("CC", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueD()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Dd";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("DD", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueE()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Ee";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("EE", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueF()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "Ff";
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("FF", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreForbiddenLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "ALB1RY2IF"; //AB12F
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual("AB12F", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("-1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "AB-1";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("AB-1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-CAB-3";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.SignValidation();
            calc.CheckChars();
            

            Assert.AreEqual(Kalkulator.CalcSystem.SystemHex, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("-CAB-3", calc.CalcValue);
        }
    }
}
