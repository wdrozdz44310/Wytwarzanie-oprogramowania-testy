using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestyKalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(null, null);
            button2_Click(null, null);
            button3_Click(null, null);
            button4_Click(null, null);
            button5_Click(null, null);
            button6_Click(null, null);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                button1.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();

                if(calc.CalcValue != "0")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                button1.BackColor = Color.Red;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                button2.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();

                if (calc.CalcSystem != Kalkulator.CalcSystem.SystemDec)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                button2.BackColor = Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                button3.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();

                if (calc.CalcTyp != Kalkulator.CalcTyp.TypQword)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                button3.BackColor = Color.Red;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                button4.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();
                calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;

                if (calc.CalcSystem != Kalkulator.CalcSystem.SystemHex)
                {
                    throw new Exception();
                }

            }
            catch (Exception)
            {
                button4.BackColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                button5.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();
                calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;

                calc.CalcValue = "A";

                if (calc.CalcValue != "A")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                button5.BackColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                button6.BackColor = Color.Green;

                var calc = new Kalkulator.Calc();
                calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;

                calc.CalcValue = "0";
                calc.CalcValue = "A";

                if (calc.CalcValue != "0")
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                button6.BackColor = Color.Red;
            }
        }
    }
}
