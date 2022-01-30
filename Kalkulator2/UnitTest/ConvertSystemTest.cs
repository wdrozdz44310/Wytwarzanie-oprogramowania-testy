using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class ConvertSystemTest
    {
        [TestMethod]
        public void ConvertSystemBinToOct1()
        {
            var calc = new Kalkulator.Calc();
            string input = "10110";
            string output = calc.ConvertSystem(2, 8, input);
            Assert.AreEqual("26", output);
        }

        [TestMethod]
        public void ConvertSystemBinToDec1()
        {
            var calc = new Kalkulator.Calc();
            string input = "10110";
            string output = calc.ConvertSystem(2, 10, input);
            Assert.AreEqual("22", output);
        }

        [TestMethod]
        public void ConvertSystemBinToHex1()
        {
            var calc = new Kalkulator.Calc();
            string input = "10110";
            string output = calc.ConvertSystem(2, 16, input);
            Assert.AreEqual("16", output);
        }

        [TestMethod]
        public void ConvertSystemBinToOct2()
        {
            var calc = new Kalkulator.Calc();
            string input = "10101110";
            string output = calc.ConvertSystem(2, 8, input);
            Assert.AreEqual("256", output);
        }

        [TestMethod]
        public void ConvertSystemBinToDec2()
        {
            var calc = new Kalkulator.Calc();
            string input = "10101110";
            string output = calc.ConvertSystem(2, 10, input);
            Assert.AreEqual("174", output);
        }

        [TestMethod]
        public void ConvertSystemBinToHex2()
        {
            var calc = new Kalkulator.Calc();
            string input = "10101110";
            string output = calc.ConvertSystem(2, 16, input);
            Assert.AreEqual("AE", output);
        }

        [TestMethod]
        public void ConvertSystemOctToBin1()
        {
            var calc = new Kalkulator.Calc();
            string input = "4573";
            string output = calc.ConvertSystem(8, 2, input);
            Assert.AreEqual("100101111011", output);
        }

        [TestMethod]
        public void ConvertSystemOctToDec1()
        {
            var calc = new Kalkulator.Calc();
            string input = "4573";
            string output = calc.ConvertSystem(8, 10, input);
            Assert.AreEqual("2427", output);
        }

        [TestMethod]
        public void ConvertSystemOctToHex1()
        {
            var calc = new Kalkulator.Calc();
            string input = "4573";
            string output = calc.ConvertSystem(8, 16, input);
            Assert.AreEqual("97B", output);
        }

        [TestMethod]
        public void ConvertSystemOctToBin2()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(8, 2, input);
            Assert.AreEqual("1010111", output);
        }

        [TestMethod]
        public void ConvertSystemOctToDec2()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(8, 10, input);
            Assert.AreEqual("87", output);
        }

        [TestMethod]
        public void ConvertSystemOctToHex2()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(8, 16, input);
            Assert.AreEqual("57", output);
        }

        [TestMethod]
        public void ConvertSystemDecToBin1()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(10, 2, input);
            Assert.AreEqual("1111111", output);
        }

        [TestMethod]
        public void ConvertSystemDecToOct1()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(10, 8, input);
            Assert.AreEqual("177", output);
        }

        [TestMethod]
        public void ConvertSystemDecToHex1()
        {
            var calc = new Kalkulator.Calc();
            string input = "127";
            string output = calc.ConvertSystem(10, 16, input);
            Assert.AreEqual("7F", output);
        }

        [TestMethod]
        public void ConvertSystemDecToBin2()
        {
            var calc = new Kalkulator.Calc();
            string input = "1234";
            string output = calc.ConvertSystem(10, 2, input);
            Assert.AreEqual("10011010010", output);
        }

        [TestMethod]
        public void ConvertSystemDecToOct2()
        {
            var calc = new Kalkulator.Calc();
            string input = "1234";
            string output = calc.ConvertSystem(10, 8, input);
            Assert.AreEqual("2322", output);
        }

        [TestMethod]
        public void ConvertSystemDecToHex2()
        {
            var calc = new Kalkulator.Calc();
            string input = "1234";
            string output = calc.ConvertSystem(10, 16, input);
            Assert.AreEqual("4D2", output);
        }

        [TestMethod]
        public void ConvertSystemHexToBin1()
        {
            var calc = new Kalkulator.Calc();
            string input = "97C";
            string output = calc.ConvertSystem(16, 2, input);
            Assert.AreEqual("100101111100", output);
        }

        [TestMethod]
        public void ConvertSystemHexToOct1()
        {
            var calc = new Kalkulator.Calc();
            string input = "97C";
            string output = calc.ConvertSystem(16, 8, input);
            Assert.AreEqual("4574", output);
        }

        [TestMethod]
        public void ConvertSystemHexToDec1()
        {
            var calc = new Kalkulator.Calc();
            string input = "97C";
            string output = calc.ConvertSystem(16, 10, input);
            Assert.AreEqual("2428", output);
        }

        [TestMethod]
        public void ConvertSystemHexToBin2()
        {
            var calc = new Kalkulator.Calc();
            string input = "E2A11";
            string output = calc.ConvertSystem(16, 2, input);
            Assert.AreEqual("11100010101000010001", output);
        }

        [TestMethod]
        public void ConvertSystemHexToOct2()
        {
            var calc = new Kalkulator.Calc();
            string input = "E2A11";
            string output = calc.ConvertSystem(16, 8, input);
            Assert.AreEqual("3425021", output);
        }

        [TestMethod]
        public void ConvertSystemHexToDec2()
        {
            var calc = new Kalkulator.Calc();
            string input = "E2A11";
            string output = calc.ConvertSystem(16, 10, input);
            Assert.AreEqual("928273", output);
        }
    }
}
