namespace Kalkulator
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.binOutputTextBox = new System.Windows.Forms.TextBox();
            this.numberSystemListBox = new System.Windows.Forms.ListBox();
            this.typListBox = new System.Windows.Forms.ListBox();
            this.Bbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cbutton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.Dbutton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.Abutton = new System.Windows.Forms.Button();
            this.Ebutton = new System.Windows.Forms.Button();
            this.Fbutton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.substractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 93);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(589, 55);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Enabled = false;
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.outputTextBox.Location = new System.Drawing.Point(13, 12);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(588, 47);
            this.outputTextBox.TabIndex = 1;
            this.outputTextBox.TextChanged += new System.EventHandler(this.outputTextBox_TextChanged);
            // 
            // binOutputTextBox
            // 
            this.binOutputTextBox.Enabled = false;
            this.binOutputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.binOutputTextBox.Location = new System.Drawing.Point(12, 65);
            this.binOutputTextBox.Name = "binOutputTextBox";
            this.binOutputTextBox.Size = new System.Drawing.Size(589, 22);
            this.binOutputTextBox.TabIndex = 2;
            // 
            // numberSystemListBox
            // 
            this.numberSystemListBox.FormattingEnabled = true;
            this.numberSystemListBox.Items.AddRange(new object[] {
            "Bin",
            "Oct",
            "Dec",
            "Hex"});
            this.numberSystemListBox.Location = new System.Drawing.Point(90, 155);
            this.numberSystemListBox.Name = "numberSystemListBox";
            this.numberSystemListBox.Size = new System.Drawing.Size(71, 56);
            this.numberSystemListBox.TabIndex = 3;
            this.numberSystemListBox.SelectedIndexChanged += new System.EventHandler(this.numberSystemListBox_SelectedIndexChanged);
            // 
            // typListBox
            // 
            this.typListBox.FormattingEnabled = true;
            this.typListBox.Items.AddRange(new object[] {
            "Byte",
            "Word",
            "Dword",
            "Qword"});
            this.typListBox.Location = new System.Drawing.Point(167, 155);
            this.typListBox.Name = "typListBox";
            this.typListBox.Size = new System.Drawing.Size(71, 56);
            this.typListBox.TabIndex = 4;
            this.typListBox.SelectedIndexChanged += new System.EventHandler(this.typListBox_SelectedIndexChanged);
            // 
            // Bbutton
            // 
            this.Bbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Bbutton.Location = new System.Drawing.Point(13, 217);
            this.Bbutton.Name = "Bbutton";
            this.Bbutton.Size = new System.Drawing.Size(71, 56);
            this.Bbutton.TabIndex = 5;
            this.Bbutton.Text = "B";
            this.Bbutton.UseVisualStyleBackColor = true;
            this.Bbutton.Click += new System.EventHandler(this.Bbutton_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(90, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 56);
            this.button1.TabIndex = 6;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(167, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 56);
            this.button2.TabIndex = 7;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cbutton
            // 
            this.Cbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Cbutton.Location = new System.Drawing.Point(13, 279);
            this.Cbutton.Name = "Cbutton";
            this.Cbutton.Size = new System.Drawing.Size(71, 56);
            this.Cbutton.TabIndex = 8;
            this.Cbutton.Text = "C";
            this.Cbutton.UseVisualStyleBackColor = true;
            this.Cbutton.Click += new System.EventHandler(this.Cbutton_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(90, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 56);
            this.button4.TabIndex = 9;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(167, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 56);
            this.button5.TabIndex = 10;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Dbutton
            // 
            this.Dbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Dbutton.Location = new System.Drawing.Point(13, 341);
            this.Dbutton.Name = "Dbutton";
            this.Dbutton.Size = new System.Drawing.Size(71, 56);
            this.Dbutton.TabIndex = 11;
            this.Dbutton.Text = "D";
            this.Dbutton.UseVisualStyleBackColor = true;
            this.Dbutton.Click += new System.EventHandler(this.Dbutton_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(90, 341);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 56);
            this.button7.TabIndex = 12;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(167, 341);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 56);
            this.button8.TabIndex = 13;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(167, 403);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 56);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // Abutton
            // 
            this.Abutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Abutton.Location = new System.Drawing.Point(13, 155);
            this.Abutton.Name = "Abutton";
            this.Abutton.Size = new System.Drawing.Size(71, 56);
            this.Abutton.TabIndex = 15;
            this.Abutton.Text = "A";
            this.Abutton.UseVisualStyleBackColor = true;
            this.Abutton.Click += new System.EventHandler(this.Abutton_Click);
            // 
            // Ebutton
            // 
            this.Ebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Ebutton.Location = new System.Drawing.Point(13, 403);
            this.Ebutton.Name = "Ebutton";
            this.Ebutton.Size = new System.Drawing.Size(71, 56);
            this.Ebutton.TabIndex = 16;
            this.Ebutton.Text = "E";
            this.Ebutton.UseVisualStyleBackColor = true;
            this.Ebutton.Click += new System.EventHandler(this.Ebutton_Click);
            // 
            // Fbutton
            // 
            this.Fbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Fbutton.Location = new System.Drawing.Point(90, 403);
            this.Fbutton.Name = "Fbutton";
            this.Fbutton.Size = new System.Drawing.Size(71, 56);
            this.Fbutton.TabIndex = 18;
            this.Fbutton.Text = "F";
            this.Fbutton.UseVisualStyleBackColor = true;
            this.Fbutton.Click += new System.EventHandler(this.Fbutton_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(244, 217);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 56);
            this.button3.TabIndex = 19;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(244, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 56);
            this.button6.TabIndex = 20;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(244, 341);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 56);
            this.button9.TabIndex = 21;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.calculateButton.Location = new System.Drawing.Point(244, 403);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(71, 56);
            this.calculateButton.TabIndex = 22;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resetButton.Location = new System.Drawing.Point(244, 155);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(71, 56);
            this.resetButton.TabIndex = 23;
            this.resetButton.Text = "Clear";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // divideButton
            // 
            this.divideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(321, 341);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(71, 56);
            this.divideButton.TabIndex = 24;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addButton.Location = new System.Drawing.Point(321, 217);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(71, 56);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multiplyButton.Location = new System.Drawing.Point(321, 403);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(71, 56);
            this.multiplyButton.TabIndex = 27;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.multiplyButton_Click);
            // 
            // substractButton
            // 
            this.substractButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.substractButton.Location = new System.Drawing.Point(321, 279);
            this.substractButton.Name = "substractButton";
            this.substractButton.Size = new System.Drawing.Size(71, 56);
            this.substractButton.TabIndex = 28;
            this.substractButton.Text = "-";
            this.substractButton.UseVisualStyleBackColor = true;
            this.substractButton.Click += new System.EventHandler(this.substractButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 469);
            this.Controls.Add(this.substractButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Fbutton);
            this.Controls.Add(this.Ebutton);
            this.Controls.Add(this.Abutton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.Dbutton);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Cbutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bbutton);
            this.Controls.Add(this.typListBox);
            this.Controls.Add(this.numberSystemListBox);
            this.Controls.Add(this.binOutputTextBox);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.TextBox binOutputTextBox;
        private System.Windows.Forms.ListBox numberSystemListBox;
        private System.Windows.Forms.ListBox typListBox;
        private System.Windows.Forms.Button Bbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Cbutton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Dbutton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button Abutton;
        private System.Windows.Forms.Button Ebutton;
        private System.Windows.Forms.Button Fbutton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button substractButton;
    }
}

