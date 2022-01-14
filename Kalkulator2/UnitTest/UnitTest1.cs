using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    // Testy inicjacji klasy
    [TestClass]
    public class ClassInitTests
    {
        // Test wartości domyślnej kalkulatora. Sprawdzenie czy metoda zwracająca bieżącą wartość kalkulatora zwraca wartość ”0”.
        [TestMethod]
        public void TestKalkValueInit()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual("0", calc.CalcValue);
        }
        // Test tworzenia obiektu klasy kalkulator. Sprawdzenie czy można utworzyć obiekt klasy przy pomocy konstruktora bezparametrowego.
        //public void TestKalkInit()
        //{
        //    var calc = new Kalkulator.Calc();
        //    Assert.AreEqual(Kalkulator.Calc, calc);
        //}

        // Test tworzenia obiektu klasy kalkulator. Sprawdzenie czy można utworzyć obiekt klasy przy pomocy konstruktora bezparametrowego.
        [TestMethod]
        public void TestKalkSystemInit()
        {
            var calc = new Kalkulator.Calc();

            Assert.AreEqual(Kalkulator.CalcSystem.SystemDec, calc.CalcSystem);
        }
        // Test domyślnego typu danych. Sprawdzenie czy metoda zwracająca bieżący typ danych zwraca wartość ”qword”.
        [TestMethod]
        public void TestKalkQwordType()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(Kalkulator.CalcTyp.TypQword, calc.CalcTyp);
        }

        // Test domyślnej wartości pól binarnych. Sprawdzenie czy metoda zwracająca bieżącą wartość pól binarnych zwraca tablicę 64 pól o wartości ”0
        [TestMethod]
        public void TestKalkBinType()
        {
            var calc = new Kalkulator.Calc();
            calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
            calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
            calc.CalcValue = "0";
            calc.SignValidation();
            calc.ConvertSystem();
            calc.ConvertTyp();


            Assert.AreEqual(64, calc.CalcValue.Length);
            Assert.AreEqual(calc.CalcValue, "0000000000000000000000000000000000000000000000000000000000000000");
        }

    }
}
