using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    /// <summary>
    /// Summary description for DecInputTest
    /// </summary>
    [TestClass]
    public class DecInputTest
    {
        [TestMethod]
        public void TestKalkValueZeros1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueZeros2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "s0ta";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("0", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "1";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "1ww";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueOnes3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "11ww";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("11", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "2";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("2", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "2ww";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("2", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueTwos3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "q22";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("22", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "3";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("3", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "3ww";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("3", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueThrees3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "w3t3";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("33", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "4";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("4", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "4qwe";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("4", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFours3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "4rt4";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("44", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "5";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("5", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "5ee";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("5", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueFives3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "w55tr";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("55", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "6";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("6", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "6ert";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("6", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueSixes()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "r6y6";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("66", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "8";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("8", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "8ad";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("8", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueEights3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "8uy8";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("88", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "9";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("9", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "9qwe9";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("99", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueNines3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "we9re";
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual(Kalkulator.CalcTyp.TypWord, calc.CalcTyp);
            Assert.AreEqual("9", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValuePlus()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "+325";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("325", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueIgnoreLetters()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "an1t";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("1", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "-24";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("-24", calc.CalcValue);
        }

        [TestMethod]
        public void TestKalkValueMinus2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcValue = "13-24";
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.SignValidation();
            calc.CheckChars();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
            Assert.AreEqual("13-24", calc.CalcValue);
        }
    }
}
