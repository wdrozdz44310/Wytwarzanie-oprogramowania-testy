using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
   // Testy inicjacji klasy
   [TestClass]
   public class ClassInitTest
   {
       // Test wartości domyślnej kalkulatora. Sprawdzenie czy metoda zwracająca bieżącą wartość kalkulatora zwraca wartość ”0”.
       [TestMethod]
       public void TestKalkValueInit()
       {
           var calc = new Kalkulator.Calc();

           Assert.AreEqual("0", calc.CalcValue);
       }

       // Test domyślnego typu danych. Sprawdzenie czy metoda zwracająca bieżący typ danych zwraca wartość ”qword”.
       [TestMethod]
       public void TestKalkQwordType()
       {
           var calc = new Kalkulator.Calc();    
           Assert.AreEqual(Kalkulator.CalcTyp.TypQword, calc.CalcTyp);
       }

       // Test domyślnej wartości pól binarnych. Sprawdzenie czy metoda zwracająca bieżącą wartość pól binarnych zwraca tablicę 64 pól o wartości ”0
       [TestMethod]
       public void TestKalkBinType()
       {
          var calc = new Kalkulator.Calc();

          Assert.AreEqual(64, calc.BinOutput.Length);
          Assert.AreEqual(calc.BinOutput, "0000000000000000000000000000000000000000000000000000000000000000");
       }

   }
}
