using System;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class Calc
    {
        private string calcValue;

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
            if (CalcValue.StartsWith("+") ||
                CalcValue.StartsWith("=") ||
                CalcValue.StartsWith("*") ||
                CalcValue.StartsWith("/") ||
                CalcValue.StartsWith("(") ||
                CalcValue.StartsWith(")"))
            {
                CalcValue = CalcValue.Remove(0, 1);
            }

            switch (CalcSystem)
            {
                case CalcSystem.SystemHex:
                    CalcValue = CalcValue.ToUpper();
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '9') && !(c >= 'A' && c <= 'F') && (c != '-'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
                case CalcSystem.SystemDec:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '9')&& (c != '-'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
                case CalcSystem.SystemBin:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '1')&& (c != '-'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
                case CalcSystem.SystemOct:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '7')&& (c != '-'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
            }

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
                        // CalcValue = Convert.ToString(Convert.ToInt16(CalcValue), 16);
                        CalcValue = CalcValue;
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypDword)
                    {
                        CalcValue = CalcValue;
                        break;
                    }
                    else if (CalcTyp == CalcTyp.TypQword)
                    {
                        CalcValue = CalcValue;
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
                default:
                    break;

            }
        }
    }

}