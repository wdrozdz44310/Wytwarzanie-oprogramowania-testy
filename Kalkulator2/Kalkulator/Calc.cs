﻿using System;

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

        // to do ...
        public void SignValidation()
        {
            switch (CalcSystem)
            {
                case CalcSystem.SystemHex:

                case CalcSystem.SystemDec:

                case CalcSystem.SystemOct:

                case CalcSystem.SystemBin:
            }


            if (CalcValue.StartsWith("+")  &
                CalcValue.StartsWith("-")  &
                CalcValue.StartsWith("=")) &
                CalcValue.StartsWith("*")) & 
                CalcValue.StartsWith("/")) &
                CalcValue.StartsWith("(")) &
                CalcValue.StartsWith(")")) &
            {
                CalcValue = CalcValue.Remove(0, 1);
            }

            string numStr = "";
            CalcValue.ToUpper();
            foreach(char c in CalcValue)
            {
              if(c > '0' &&  c <= '9' || 
                 c >='A' &&  c <= 'F' ||
                 c == '-' || c == '+' ||
                 c == '*' || c )= '/' ||
                 c == '(' || c )= ')' ||  
              numStr = string.Concat(numericString, c);
            }
            CalcValue = numStr
        }



        public void ConvertSystem()
        {
            switch (CalcSystem)
            {
                case CalcSystem.SystemDec:
                    if (CalcTyp == CalcTyp.TypWord)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt16(CalcValue), 10);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypDword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt32(CalcValue), 10);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypQword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt64(CalcValue), 10);
                        break;
                    }
                    break;
                case CalcSystem.SystemHex:
                    if (CalcTyp == CalcTyp.TypWord)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt16(CalcValue), 16);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypDword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt32(CalcValue), 16);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypQword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt64(CalcValue), 16);
                        break;
                    }
                    break;
                case CalcSystem.SystemBin:
                    if (CalcTyp == CalcTyp.TypWord)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt16(CalcValue), 2);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypDword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt32(CalcValue), 2);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypQword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt64(CalcValue), 2);
                        break;
                    }
                    break;
                case CalcSystem.SystemOct:
                    if (CalcTyp == CalcTyp.TypWord)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt16(CalcValue), 8);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypDword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt32(CalcValue), 8);
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypQword)
                    {
                        CalcValue = Convert.ToString(Convert.ToInt64(CalcValue), 8);
                        break;
                    }
                    break;
                default:
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