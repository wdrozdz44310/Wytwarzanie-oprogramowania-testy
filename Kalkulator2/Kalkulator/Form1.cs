using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        Kalkulator.Calc calc;
        int prevNumberSystem, prevTyp;
        public Form1()
        {
            InitializeComponent();
            calc = new Kalkulator.Calc();
            prevNumberSystem = 10;
            prevTyp = 64;
            outputTextBox.Text = "0";
            numberSystemListBox.SelectedIndex = 2;
            typListBox.SelectedIndex = 3;
            binOutputTextBox.Text = calc.BinOutput;
        }

        private void inputTextBox_TextChanged(object sender, System.EventArgs e)
        {
            calc.CalcValue = inputTextBox.Text;
            calc.SignValidation();
            calc.CheckChars();
            inputTextBox.Text = calc.CalcValue;
        }

        private void numberSystemListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string newText;
            if (numberSystemListBox.SelectedIndex == 0)
            {
                calc.CalcSystem = Kalkulator.CalcSystem.SystemBin;
                if(inputTextBox.Text != "")
                {
                    calc.ParseValues();
                    newText = calc.ConvertSystem(prevNumberSystem, 2, calc.ParsedValues[0]);
                    if (calc.ParsedValues[1] != "")
                        newText += calc.ParsedValues[1];
                    if (calc.ParsedValues[2] != "")
                        newText += calc.ConvertSystem(prevNumberSystem, 2, calc.ParsedValues[2]);
                    inputTextBox.Text = newText;
                }
                
                newText = calc.ConvertSystem(prevNumberSystem, 2, outputTextBox.Text);
                outputTextBox.Text = newText;
                prevNumberSystem = 2;
            }
            else if (numberSystemListBox.SelectedIndex == 1)
            {
                calc.CalcSystem = Kalkulator.CalcSystem.SystemOct;
                if (inputTextBox.Text != "")
                {
                    calc.ParseValues();
                    newText = calc.ConvertSystem(prevNumberSystem, 8, calc.ParsedValues[0]);
                    if (calc.ParsedValues[1] != "")
                        newText += calc.ParsedValues[1];
                    if (calc.ParsedValues[2] != "")
                        newText += calc.ConvertSystem(prevNumberSystem, 8, calc.ParsedValues[2]);
                    inputTextBox.Text = newText;
                }
                newText = calc.ConvertSystem(prevNumberSystem, 8, outputTextBox.Text);
                outputTextBox.Text = newText;
                prevNumberSystem = 8;
            }
            else if (numberSystemListBox.SelectedIndex == 2)
            {
                calc.CalcSystem = Kalkulator.CalcSystem.SystemDec;
                if (inputTextBox.Text != "")
                {
                    calc.ParseValues();
                    newText = calc.ConvertSystem(prevNumberSystem, 10, calc.ParsedValues[0]);
                    if (calc.ParsedValues[1] != "")
                        newText += calc.ParsedValues[1];
                    if (calc.ParsedValues[2] != "")
                        newText += calc.ConvertSystem(prevNumberSystem, 10, calc.ParsedValues[2]);
                    inputTextBox.Text = newText;
                }
                newText = calc.ConvertSystem(prevNumberSystem, 10, outputTextBox.Text);
                outputTextBox.Text = newText;
                prevNumberSystem = 10;
            }
            else
            {
                calc.CalcSystem = Kalkulator.CalcSystem.SystemHex;
                if (inputTextBox.Text != "")
                {
                    calc.ParseValues();
                    newText = calc.ConvertSystem(prevNumberSystem, 16, calc.ParsedValues[0]);
                    if(calc.ParsedValues[1] != "")
                        newText += calc.ParsedValues[1];
                    if(calc.ParsedValues[2] != "")
                        newText += calc.ConvertSystem(prevNumberSystem, 16, calc.ParsedValues[2]);

                    inputTextBox.Text = newText;
                }
                newText = calc.ConvertSystem(prevNumberSystem, 16, outputTextBox.Text);
                outputTextBox.Text = newText;
                prevNumberSystem = 16;
            }
        }

        private void typListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (typListBox.SelectedIndex == 0)
            {
                calc.CalcTyp = Kalkulator.CalcTyp.TypByte;
                calc.ConvertTyp(prevNumberSystem, prevTyp);
                prevTyp = 8;
            }
            else if (typListBox.SelectedIndex == 1)
            {
                calc.CalcTyp = Kalkulator.CalcTyp.TypWord;
                calc.ConvertTyp(prevNumberSystem, prevTyp);
                prevTyp = 16;
            }
            else if (typListBox.SelectedIndex == 2)
            {
                calc.CalcTyp = Kalkulator.CalcTyp.TypDword;
                calc.ConvertTyp(prevNumberSystem, prevTyp);
                prevTyp = 32;
            }
            else
            {
                calc.CalcTyp = Kalkulator.CalcTyp.TypQword;
                calc.ConvertTyp(prevNumberSystem, prevTyp);
                prevTyp = 64;
            }

            binOutputTextBox.Text = calc.BinOutput;
            outputTextBox.Text = calc.OutputCalcValue;
        }

        private void Abutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "A";
        }

        private void Bbutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "B";
        }

        private void Cbutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "C";
        }

        private void Dbutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "D";
        }

        private void Ebutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "E";
        }

        private void Fbutton_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem == Kalkulator.CalcSystem.SystemHex)
                inputTextBox.Text += "F";
        }

        private void button0_Click(object sender, System.EventArgs e)
        {
            if (inputTextBox.Text != "")
                inputTextBox.Text += "0";
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text += "1";
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "2";
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "3";
        }

        private void button4_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "4";
        }

        private void button5_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "5";
        }

        private void button6_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "6";
        }

        private void button7_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin)
                inputTextBox.Text += "7";
        }

        private void button8_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin && calc.CalcSystem != Kalkulator.CalcSystem.SystemOct)
                inputTextBox.Text += "8";
        }

        private void button9_Click(object sender, System.EventArgs e)
        {
            if (calc.CalcSystem != Kalkulator.CalcSystem.SystemBin && calc.CalcSystem != Kalkulator.CalcSystem.SystemOct)
                inputTextBox.Text += "9";
        }

        private void addButton_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text += "+";
        }

        private void substractButton_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text += "-";
        }

        private void divideButton_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text += "/";
        }

        private void multiplyButton_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text += "*";
        }

        private void calculateButton_Click(object sender, System.EventArgs e)
        {
            calc.ParseValues();
            calc.CalculateValues(prevTyp);
            outputTextBox.Text = calc.OutputCalcValue;
        }

        private void outputTextBox_TextChanged(object sender, System.EventArgs e)
        {
            binOutputTextBox.Text = calc.BinOutput;
        }

        private void resetButton_Click(object sender, System.EventArgs e)
        {
            inputTextBox.Text = "";
            calc.OutputCalcValue = "0";
            calc.BinOutput = "0";
            outputTextBox.Text = calc.OutputCalcValue;
            calc.ConvertTyp(prevNumberSystem, prevTyp);
            binOutputTextBox.Text = calc.BinOutput;
        }
    }
}
