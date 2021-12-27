using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Calc
    {
        private string calcValue, calcBinValue;

        public string CalcValue {
            get { return calcValue;  }
            set { calcValue = value; }
        }

        public string CalcBinValue {
            get { return calcBinValue;  }
            set { calcBinValue = value; }
        }

        public CalcSystem CalcSystem { get; set; }
        public CalcTyp CalcTyp { get; set; }

        public Calc()
        {
            CalcValue = "0";
            CalcBinValue = "0000000000000000000000000000000000000000000000000000000000000000";
            CalcSystem = CalcSystem.SystemDec;
        }
    }
}
