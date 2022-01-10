using System;

namespace Kalkulator
{
    public class Calc
    {
        private string calcValue, calcBinValue;

        public string CalcValue
        {
            get { return calcValue; }
            set { calcValue = value; }
        }



        public CalcSystem CalcSystem { get; set; }
        public CalcTyp CalcTyp { get; set; }

        public Calc()
        {
            CalcValue = "0";
            CalcSystem = CalcSystem.SystemDec;
            CalcTyp = CalcTyp.TypQword;
        }

        public void SignValidation()
        {
            if (CalcValue.StartsWith("+"))
            {
                CalcValue = CalcValue.Remove(0, 1);
            }

        }



        public void ConvertSystem()
        {
            switch (CalcSystem)
            {
                case CalcSystem.SystemDec:
                    CalcValue = Convert.ToString(Convert.ToInt64(CalcValue, 10));
                    break;
                case CalcSystem.SystemHex:
                    CalcValue = Convert.ToString(Convert.ToInt64(CalcValue, 16));
                    break;
                case CalcSystem.SystemBin:
                    CalcValue = Convert.ToString(Convert.ToInt64(CalcValue, 2));
                    break;
            }
        }


        public void ConvertTyp()
        {
            switch (CalcTyp)
            {
                case CalcTyp.TypQword:
                    CalcValue = CalcValue.PadLeft(64, '0');
                    break;
                case CalcTyp.TypDword:
                    CalcValue = CalcValue.PadLeft(32, '0');
                    break;
                case CalcTyp.TypWord:
                    CalcValue = CalcValue.PadLeft(16, '0');
                    break;
            }
        }
    }

}