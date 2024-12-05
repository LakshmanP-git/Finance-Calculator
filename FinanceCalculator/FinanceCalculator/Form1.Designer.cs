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
            outputBox = new TextBox();
            btnClear = new Button();
            btnPlus = new Button();
            btnMinus = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnPeriod = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            tabInterest = new TabPage();
            btnCalculate = new Button();
            cmpdOutput = new TextBox();
            grpFrequency = new GroupBox();
            rdoAnnually = new RadioButton();
            rdoSemi = new RadioButton();
            rdoQtr = new RadioButton();
            rdoMonthly = new RadioButton();
            txtYears = new TextBox();
            txtInterest = new TextBox();
            txtDollars = new TextBox();
            lblYears = new Label();
            lblRate = new Label();
            lblAmount = new Label();
            calculatorTabs.SuspendLayout();
            tabCalculator.SuspendLayout();
            tabInterest.SuspendLayout();
            grpFrequency.SuspendLayout();
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
            // outputBox
            // 
            outputBox.Font = new Font("Segoe UI", 25F);
            outputBox.Location = new Point(246, 28);
            outputBox.Name = "outputBox";
            outputBox.Size = new Size(282, 52);
            outputBox.TabIndex = 17;
            outputBox.Text = "0";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 14F);
            btnClear.Location = new Point(318, 360);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(138, 46);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 15F);
            btnPlus.Location = new Point(462, 218);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(66, 60);
            btnPlus.TabIndex = 15;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnAdd_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Segoe UI", 15F);
            btnMinus.Location = new Point(462, 284);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(66, 60);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += btnSubtract_Click;
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
            btnMultiply.Click += btnMultiply_Click;
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
            btnDivide.Click += btnDivide_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.DimGray;
            btnEquals.Font = new Font("Segoe UI", 15F);
            btnEquals.ForeColor = SystemColors.ButtonFace;
            btnEquals.Location = new Point(390, 284);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(66, 60);
            btnEquals.TabIndex = 11;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPeriod
            // 
            btnPeriod.BackColor = Color.DimGray;
            btnPeriod.Font = new Font("Segoe UI", 15F);
            btnPeriod.ForeColor = SystemColors.ButtonFace;
            btnPeriod.Location = new Point(318, 284);
            btnPeriod.Name = "btnPeriod";
            btnPeriod.Size = new Size(66, 60);
            btnPeriod.TabIndex = 10;
            btnPeriod.Text = ".";
            btnPeriod.UseVisualStyleBackColor = false;
            btnPeriod.Click += btnPeriod_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.DimGray;
            btn9.Font = new Font("Segoe UI", 15F);
            btn9.ForeColor = SystemColors.ButtonFace;
            btn9.Location = new Point(390, 86);
            btn9.Name = "btn9";
            btn9.Size = new Size(66, 60);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.DimGray;
            btn8.Font = new Font("Segoe UI", 15F);
            btn8.ForeColor = SystemColors.ButtonFace;
            btn8.Location = new Point(318, 86);
            btn8.Name = "btn8";
            btn8.Size = new Size(66, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.DimGray;
            btn7.Font = new Font("Segoe UI", 15F);
            btn7.ForeColor = SystemColors.ButtonFace;
            btn7.Location = new Point(246, 86);
            btn7.Name = "btn7";
            btn7.Size = new Size(66, 60);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.DimGray;
            btn6.Font = new Font("Segoe UI", 15F);
            btn6.ForeColor = SystemColors.ButtonFace;
            btn6.Location = new Point(390, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(66, 60);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.DimGray;
            btn5.Font = new Font("Segoe UI", 15F);
            btn5.ForeColor = SystemColors.ButtonFace;
            btn5.Location = new Point(318, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(66, 60);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.DimGray;
            btn4.Font = new Font("Segoe UI", 15F);
            btn4.ForeColor = SystemColors.ButtonFace;
            btn4.Location = new Point(246, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(66, 60);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.DimGray;
            btn3.Font = new Font("Segoe UI", 15F);
            btn3.ForeColor = SystemColors.ButtonFace;
            btn3.Location = new Point(390, 218);
            btn3.Name = "btn3";
            btn3.Size = new Size(66, 60);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.DimGray;
            btn2.Font = new Font("Segoe UI", 15F);
            btn2.ForeColor = SystemColors.ButtonFace;
            btn2.Location = new Point(318, 218);
            btn2.Name = "btn2";
            btn2.Size = new Size(66, 60);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.DimGray;
            btn1.Font = new Font("Segoe UI", 15F);
            btn1.ForeColor = SystemColors.ButtonFace;
            btn1.Location = new Point(246, 218);
            btn1.Name = "btn1";
            btn1.Size = new Size(66, 60);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.DimGray;
            btn0.Font = new Font("Segoe UI", 15F);
            btn0.ForeColor = SystemColors.ButtonFace;
            btn0.Location = new Point(246, 284);
            btn0.Name = "btn0";
            btn0.Size = new Size(66, 60);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // tabInterest
            // 
            tabInterest.Controls.Add(btnCalculate);
            tabInterest.Controls.Add(cmpdOutput);
            tabInterest.Controls.Add(grpFrequency);
            tabInterest.Controls.Add(txtYears);
            tabInterest.Controls.Add(txtInterest);
            tabInterest.Controls.Add(txtDollars);
            tabInterest.Controls.Add(lblYears);
            tabInterest.Controls.Add(lblRate);
            tabInterest.Controls.Add(lblAmount);
            tabInterest.Location = new Point(4, 24);
            tabInterest.Name = "tabInterest";
            tabInterest.Padding = new Padding(3);
            tabInterest.Size = new Size(794, 422);
            tabInterest.TabIndex = 1;
            tabInterest.Text = "Compound Interest";
            tabInterest.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 15F);
            btnCalculate.Location = new Point(185, 319);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(119, 42);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cmpdOutput
            // 
            cmpdOutput.Font = new Font("Segoe UI", 20F);
            cmpdOutput.Location = new Point(334, 319);
            cmpdOutput.Name = "cmpdOutput";
            cmpdOutput.Size = new Size(249, 43);
            cmpdOutput.TabIndex = 7;
            // 
            // grpFrequency
            // 
            grpFrequency.Controls.Add(rdoAnnually);
            grpFrequency.Controls.Add(rdoSemi);
            grpFrequency.Controls.Add(rdoQtr);
            grpFrequency.Controls.Add(rdoMonthly);
            grpFrequency.Location = new Point(203, 226);
            grpFrequency.Name = "grpFrequency";
            grpFrequency.Size = new Size(428, 70);
            grpFrequency.TabIndex = 6;
            grpFrequency.TabStop = false;
            grpFrequency.Text = "Compound Frequency";
            // 
            // rdoAnnually
            // 
            rdoAnnually.AutoSize = true;
            rdoAnnually.Location = new Point(331, 33);
            rdoAnnually.Name = "rdoAnnually";
            rdoAnnually.Size = new Size(72, 19);
            rdoAnnually.TabIndex = 3;
            rdoAnnually.TabStop = true;
            rdoAnnually.Text = "Annually";
            rdoAnnually.UseVisualStyleBackColor = true;
            // 
            // rdoSemi
            // 
            rdoSemi.AutoSize = true;
            rdoSemi.Location = new Point(225, 33);
            rdoSemi.Name = "rdoSemi";
            rdoSemi.Size = new Size(96, 19);
            rdoSemi.TabIndex = 2;
            rdoSemi.TabStop = true;
            rdoSemi.Text = "Semiannually";
            rdoSemi.UseVisualStyleBackColor = true;
            // 
            // rdoQtr
            // 
            rdoQtr.AutoSize = true;
            rdoQtr.Location = new Point(131, 33);
            rdoQtr.Name = "rdoQtr";
            rdoQtr.Size = new Size(74, 19);
            rdoQtr.TabIndex = 1;
            rdoQtr.TabStop = true;
            rdoQtr.Text = "Quarterly";
            rdoQtr.UseVisualStyleBackColor = true;
            // 
            // rdoMonthly
            // 
            rdoMonthly.AutoSize = true;
            rdoMonthly.Location = new Point(31, 33);
            rdoMonthly.Name = "rdoMonthly";
            rdoMonthly.Size = new Size(70, 19);
            rdoMonthly.TabIndex = 0;
            rdoMonthly.TabStop = true;
            rdoMonthly.Text = "Monthly";
            rdoMonthly.UseVisualStyleBackColor = true;
            // 
            // txtYears
            // 
            txtYears.Font = new Font("Segoe UI", 20F);
            txtYears.Location = new Point(428, 166);
            txtYears.Name = "txtYears";
            txtYears.Size = new Size(203, 43);
            txtYears.TabIndex = 5;
            // 
            // txtInterest
            // 
            txtInterest.Font = new Font("Segoe UI", 20F);
            txtInterest.Location = new Point(428, 108);
            txtInterest.Name = "txtInterest";
            txtInterest.Size = new Size(203, 43);
            txtInterest.TabIndex = 4;
            // 
            // txtDollars
            // 
            txtDollars.Font = new Font("Segoe UI", 20F);
            txtDollars.Location = new Point(428, 51);
            txtDollars.Name = "txtDollars";
            txtDollars.Size = new Size(203, 43);
            txtDollars.TabIndex = 3;
            // 
            // lblYears
            // 
            lblYears.AutoSize = true;
            lblYears.Font = new Font("Segoe UI", 23F);
            lblYears.Location = new Point(137, 155);
            lblYears.Name = "lblYears";
            lblYears.Size = new Size(245, 42);
            lblYears.TabIndex = 2;
            lblYears.Text = "Number of Years";
            // 
            // lblRate
            // 
            lblRate.AutoSize = true;
            lblRate.Font = new Font("Segoe UI", 23F);
            lblRate.Location = new Point(154, 98);
            lblRate.Name = "lblRate";
            lblRate.Size = new Size(228, 42);
            lblRate.TabIndex = 1;
            lblRate.Text = "Rate of Interest";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 23F);
            lblAmount.Location = new Point(76, 42);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(306, 42);
            lblAmount.TabIndex = 0;
            lblAmount.Text = "Initial Dollar Amount";
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
            tabInterest.ResumeLayout(false);
            tabInterest.PerformLayout();
            grpFrequency.ResumeLayout(false);
            grpFrequency.PerformLayout();
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
        private Label lblYears;
        private Label lblRate;
        private Label lblAmount;
        private GroupBox grpFrequency;
        private TextBox txtYears;
        private TextBox txtInterest;
        private TextBox txtDollars;
        private TextBox cmpdOutput;
        private Button btnCalculate;
        private RadioButton rdoAnnually;
        private RadioButton rdoSemi;
        private RadioButton rdoQtr;
        private RadioButton rdoMonthly;
    }
}
