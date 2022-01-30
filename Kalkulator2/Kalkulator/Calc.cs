using System;
using System.Data;
using System.Linq;
using System.Text;

namespace Kalkulator
{
    public class Calc
    {
        private string calcValue;
        private string outputCalcValue;
        private string binOutput;
        string[] parsedValues = new string[3];

        public string CalcValue
        {
            get { return calcValue; }
            set { calcValue = value; }
        }

        public string BinOutput
        {
            get { return binOutput; }
            set { binOutput = value; }
        }

        public string OutputCalcValue
        {
            get { return outputCalcValue; }
            set { outputCalcValue = value; }
        }

        public string[] ParsedValues
        {
            get { return parsedValues; }
            set { parsedValues = value; }
        }

        public CalcSystem CalcSystem { get; set; }
        public CalcTyp CalcTyp { get; set; }

        public Calc()
        {
            CalcValue = "0";
            CalcSystem = CalcSystem.SystemDec;
            CalcTyp = CalcTyp.TypQword;
            OutputCalcValue = "0";
            for (int i = 0; i < 64; i++)
                BinOutput += "0";
        }

        // dzeli wyrażenie np. 2+4 na "2" "+" "4"
        public void ParseValues()
        {
            parsedValues[0] = "";
            parsedValues[1] = "";
            parsedValues[2] = "";

            int signIndex = 0;

            for (int i = 0; (i == 0 && CalcValue[i] == '-') || (CalcValue[i] != '+' && CalcValue[i] != '-' && CalcValue[i] != '*' && CalcValue[i] != '/'); i++)
            {
                parsedValues[0] += CalcValue[i];
                signIndex++;

                if (i == CalcValue.Length - 1)
                    break;
            }

            if (signIndex == CalcValue.Length)
                return;

            parsedValues[1] = Convert.ToString(CalcValue[signIndex]);
            signIndex++;

            for (int i = signIndex; i < CalcValue.Length; i++)
            {
                parsedValues[2] += CalcValue[i];
                signIndex++;
            }
        }

        // oblicza dla =,-,*,/
        public void CalculateValues(int typ)
        {
            if (ParsedValues[1] == "")
                outputCalcValue = ParsedValues[0].ToString();

            int oldSystem;
            if (CalcSystem == CalcSystem.SystemDec)
                oldSystem = 10;
            else if (CalcSystem == CalcSystem.SystemHex)
                oldSystem = 16;
            else if (CalcSystem == CalcSystem.SystemBin)
                oldSystem = 2;
            else
                oldSystem = 8;

            string input1, input2;

            input1 = ConvertSystem(oldSystem, 10, ParsedValues[0]);
            input2 = ConvertSystem(oldSystem, 10, ParsedValues[2]);

            int result;
            if (ParsedValues[1] == "+")
                result = Int32.Parse(input1) + Int32.Parse(input2);
            else if (ParsedValues[1] == "-")
                result = Int32.Parse(input1) - Int32.Parse(input2);
            else if (ParsedValues[1] == "*")
                result = Int32.Parse(input1) * Int32.Parse(input2);
            else if (ParsedValues[1] == "/")
                result = Int32.Parse(input1) / Int32.Parse(input2);
            else
                result = 0;

            OutputCalcValue = ConvertSystem(10, oldSystem, result.ToString());
            BinOutput = ConvertSystem(oldSystem, 2, OutputCalcValue);
            ConvertTyp(oldSystem, typ);
        }

        // sprawdza czy wpisany znak działania jest dozwolony   
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
        }

        // sprawdza czy w ciągu znaków wszystkie znaki są dozwolone dla danego systemu liczbowego
        public void CheckChars()
        {
            switch (CalcSystem)
            {
                case CalcSystem.SystemHex:
                    CalcValue = CalcValue.ToUpper();
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '9') && !(c >= 'A' && c <= 'F') && (c != '-') && (c != '+') && (c != '*') && (c != '/'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }
                    }
                    break;
                case CalcSystem.SystemDec:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '9') && (c != '-') && (c != '+') && (c != '*') && (c != '/'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
                case CalcSystem.SystemBin:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '1') && (c != '-') && (c != '+') && (c != '*') && (c != '/'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }

                    }
                    break;
                case CalcSystem.SystemOct:
                    foreach (char c in CalcValue)
                    {
                        if (!(c >= '0' && c <= '7') && (c != '-') && (c != '+') && (c != '*') && (c != '/'))
                        {
                            CalcValue = CalcValue.Remove(CalcValue.IndexOf(c), 1);
                        }
                    }
                    break;
            }
        }

        public string ConvertSystem(int oldSystem, int newSystem, string input)
        {
            string changedInput = input;

            if (oldSystem != newSystem)
            {
                switch(CalcTyp)
                {
                    case CalcTyp.TypByte:
                        changedInput = Convert.ToString(Convert.ToSByte(input, oldSystem), newSystem);
                        break;
                    case CalcTyp.TypWord:
                        changedInput = Convert.ToString(Convert.ToInt16(input, oldSystem), newSystem);
                        break;
                    case CalcTyp.TypDword:
                        changedInput = Convert.ToString(Convert.ToInt32(input, oldSystem), newSystem);
                        break;
                    case CalcTyp.TypQword:
                        changedInput = Convert.ToString(Convert.ToInt64(input, oldSystem), newSystem);
                        break;
                }
            }
                

            return changedInput.ToUpper();
        }

        public void ConvertTyp(int system, int prevTyp)
        {
            int zeros = 0;
            string tmp = "";
            string sign;
            int typ = 64;
            switch (CalcTyp)
            {
                case CalcTyp.TypQword:
                    if (BinOutput.Length > 64)
                    {
                        while (BinOutput.Length > 64)
                            BinOutput = BinOutput.Remove(0, 1);
                    }
                    zeros = 64 - BinOutput.Length;
                    typ = 64;
                    break;

                case CalcTyp.TypDword:
                    if (BinOutput.Length > 32)
                    {
                        while (BinOutput.Length > 32)
                            BinOutput = BinOutput.Remove(0, 1);
                    }
                    zeros = 32 - BinOutput.Length;
                    typ = 32;
                    break;

                case CalcTyp.TypWord:
                    if (BinOutput.Length > 16)
                    {
                        while (BinOutput.Length > 16)
                            BinOutput = BinOutput.Remove(0, 1);
                    }
                    zeros = 16 - BinOutput.Length;
                    typ = 16;
                    break;

                case CalcTyp.TypByte:
                    if (BinOutput.Length > 8)
                    {
                        while (BinOutput.Length > 8)
                            BinOutput = BinOutput.Remove(0, 1);
                    }
                    zeros = 8 - BinOutput.Length;
                    typ = 8;
                    break;

                default:
                    break;
            }

            tmp = "";

            if ((BinOutput.Length == prevTyp && BinOutput[0] == '1'))
                sign = "1";
            else
            {
                sign = "0";
                OutputCalcValue = ConvertSystem(2, system, BinOutput);
                while (OutputCalcValue.Length > 1)
                {
                    if (OutputCalcValue[0] == '0')
                        OutputCalcValue = OutputCalcValue.Remove(0, 1);
                    else
                        break;
                }
            }

            for (int i = 0; i < zeros; i++)
                tmp += sign;

            BinOutput = tmp + BinOutput;

            if (sign == "1")
                OutputCalcValue = ConvertSystem(2, system, BinOutput);
        }
    }
}