using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class KalkTest
    {
        [TestMethod]
        public void TestParseValuesPlusSign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "2+4";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("2", calc.ParsedValues[0]);
            Assert.AreEqual("+", calc.ParsedValues[1]);
            Assert.AreEqual("4", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestParseValuesMinusSign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "2-4";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("2", calc.ParsedValues[0]);
            Assert.AreEqual("-", calc.ParsedValues[1]);
            Assert.AreEqual("4", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestParseValuesPlusSign2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "20+40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("20", calc.ParsedValues[0]);
            Assert.AreEqual("+", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }
        [TestMethod]
        public void TestParseValuesDivideSign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "20/40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("20", calc.ParsedValues[0]);
            Assert.AreEqual("/", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }
        [TestMethod]
        public void TestParseValuesMultiplySign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "20*40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("20", calc.ParsedValues[0]);
            Assert.AreEqual("*", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestParseValuesMinusMultiplySign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
            calc.CalcValue = "-20*40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("-20", calc.ParsedValues[0]);
            Assert.AreEqual("*", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestParseValuesHexMinusMultiplySign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "-A*40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("-A", calc.ParsedValues[0]);
            Assert.AreEqual("*", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestParseValuesHexAddSign()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "A+40";
            calc.SignValidation();
            calc.ParseValues();
            Assert.AreEqual("A", calc.ParsedValues[0]);
            Assert.AreEqual("+", calc.ParsedValues[1]);
            Assert.AreEqual("40", calc.ParsedValues[2]);
        }

        [TestMethod]
        public void TestCalculateValuesHex1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "8+B";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("13", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesHex2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "B-8";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("3", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesHex3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "8*B";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("58", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesHex4()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "B4/2D";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("4", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesHex5()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
            calc.CalcValue = "8-B";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            calc.ConvertTyp(16, 16);
            Assert.AreEqual("FFFD", calc.OutputCalcValue);
        }


        [TestMethod]
        public void TestCalculateValuesOct()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "7+25";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("34", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesOct2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "75-66";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("7", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesOct3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "52*4";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("250", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesOct4()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
            calc.CalcValue = "314/6";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("42", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesBin1()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "1001+1101";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("10110", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesBin2()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "1111011-101";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("1110110", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesBin3()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "101*11";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("1111", calc.OutputCalcValue);
        }

        [TestMethod]
        public void TestCalculateValuesBin4()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "111010/11";
            calc.SignValidation();
            calc.ParseValues();
            calc.CalculateValues(16);
            Assert.AreEqual("10011", calc.OutputCalcValue);
        }


    }
}
