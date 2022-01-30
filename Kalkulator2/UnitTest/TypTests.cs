using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class TypTests
    {
        [TestMethod]
        public void BinInputQwordToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputQwordToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputQwordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputDwordToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputDwordToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputDwordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputWordToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputWordToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputWordToByte()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputByteToQword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.ConvertTyp(10);
            Assert.AreEqual(64, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000000000000000000000000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputByteToDword()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
            calc.ConvertTyp(10);
            Assert.AreEqual(32, calc.BinOutput.Length);
            Assert.AreEqual("00000000000000000000000000000000", calc.BinOutput);
        }

        [TestMethod]
        public void BinInputByteToWord()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
            calc.ConvertTyp(10);
            Assert.AreEqual(8, calc.BinOutput.Length);
            Assert.AreEqual("00000000", calc.BinOutput);
            calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
            calc.ConvertTyp(10);
            Assert.AreEqual(16, calc.BinOutput.Length);
            Assert.AreEqual("0000000000000000", calc.BinOutput);
        }
    }
}
