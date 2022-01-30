using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class TypTests
    {
        [TestMethod]
        public void BinOutputQwordToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputQwordToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputQwordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputDwordToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10, 32);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputDwordToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 32);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputDwordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 32);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputWordToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10, 16);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputWordToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 16);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputWordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 16);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputByteToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10, 8);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputByteToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10, 8);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinOutputByteToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10, 64);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10, 8);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }
    }
}
