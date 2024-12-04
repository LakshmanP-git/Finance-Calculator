namespace FinanceCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculatorTabs = new TabControl();
            tabCalculator = new TabPage();
            tabInterest = new TabPage();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnPeriod = new Button();
            btnEquals = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnMinus = new Button();
            btnPlus = new Button();
            btnClear = new Button();
            outputBox = new TextBox();
            calculatorTabs.SuspendLayout();
            tabCalculator.SuspendLayout();
            SuspendLayout();
            // 
            // calculatorTabs
            // 
            calculatorTabs.Controls.Add(tabCalculator);
            calculatorTabs.Controls.Add(tabInterest);
            calculatorTabs.Location = new Point(0, -1);
            calculatorTabs.Name = "calculatorTabs";
            calculatorTabs.SelectedIndex = 0;
            calculatorTabs.Size = new Size(802, 450);
            calculatorTabs.TabIndex = 0;
            // 
            // tabCalculator
            // 
            tabCalculator.BackColor = Color.Black;
            tabCalculator.Controls.Add(outputBox);
            tabCalculator.Controls.Add(btnClear);
            tabCalculator.Controls.Add(btnPlus);
            tabCalculator.Controls.Add(btnMinus);
            tabCalculator.Controls.Add(btnMultiply);
            tabCalculator.Controls.Add(btnDivide);
            tabCalculator.Controls.Add(btnEquals);
            tabCalculator.Controls.Add(btnPeriod);
            tabCalculator.Controls.Add(btn9);
            tabCalculator.Controls.Add(btn8);
            tabCalculator.Controls.Add(btn7);
            tabCalculator.Controls.Add(btn6);
            tabCalculator.Controls.Add(btn5);
            tabCalculator.Controls.Add(btn4);
            tabCalculator.Controls.Add(btn3);
            tabCalculator.Controls.Add(btn2);
            tabCalculator.Controls.Add(btn1);
            tabCalculator.Controls.Add(btn0);
            tabCalculator.Location = new Point(4, 24);
            tabCalculator.Name = "tabCalculator";
            tabCalculator.Padding = new Padding(3);
            tabCalculator.Size = new Size(794, 422);
            tabCalculator.TabIndex = 0;
            tabCalculator.Text = "Calculator";
            // 
            // tabInterest
            // 
            tabInterest.Location = new Point(4, 24);
            tabInterest.Name = "tabInterest";
            tabInterest.Padding = new Padding(3);
            tabInterest.Size = new Size(794, 422);
            tabInterest.TabIndex = 1;
            tabInterest.Text = "Compound Interest";
            tabInterest.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 15F);
            btn0.Location = new Point(246, 284);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 60);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 15F);
            btn1.Location = new Point(246, 218);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 60);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 15F);
            btn2.Location = new Point(318, 218);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 60);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 15F);
            btn3.Location = new Point(390, 218);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 60);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 15F);
            btn4.Location = new Point(246, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 15F);
            btn5.Location = new Point(318, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 15F);
            btn6.Location = new Point(390, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 15F);
            btn7.Location = new Point(246, 86);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 60);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 15F);
            btn8.Location = new Point(318, 86);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 15F);
            btn9.Location = new Point(390, 86);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnPeriod
            // 
            btnPeriod.Font = new Font("Segoe UI", 15F);
            btnPeriod.Location = new Point(318, 284);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(66, 60);
            btnPeriod.TabIndex = 10;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.Font = new Font("Segoe UI", 15F);
            btnEquals.Location = new Point(390, 284);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(66, 60);
            btnEquals.TabIndex = 11;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Font = new Font("Segoe UI", 15F);
            btnDivide.Location = new Point(462, 86);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(66, 60);
            btnDivide.TabIndex = 12;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Font = new Font("Segoe UI", 15F);
            btnMultiply.Location = new Point(462, 152);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(66, 60);
            btnMultiply.TabIndex = 13;
            btnMultiply.Text = "x";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 15F);
            btnMinus.Location = new Point(462, 218);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(66, 60);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 15F);
            btnPlus.Location = new Point(462, 284);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(66, 60);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(318, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 46);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // outputBox
            // 
            outputBox.Font = new Font("Segoe UI", 25F);
            outputBox.Location = new Point(246, 28);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(282, 52);
            outputBox.TabIndex = 17;
            outputBox.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calculatorTabs);
            Name = "Form1";
            Text = "Finance Calculator";
            Load += Form1_Load;
            calculatorTabs.ResumeLayout(false);
            tabCalculator.ResumeLayout(false);
            tabCalculator.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl calculatorTabs;
        private TabPage tabCalculator;
        private TabPage tabInterest;
        private Button btnPlus;
        private Button btnMinus;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnPeriod;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btn0;
        private Button btnClear;
        private TextBox outputBox;
    }
}
