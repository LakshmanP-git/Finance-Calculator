using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace FinanceCalculator
{
    public partial class Form1 : Form
    {
        public int firstOrSecondTimeDivision;
        public int firstOrSecondTimeMultiply;
        public int firstOrSecondTimeAdd;
        public int firstOrSecondTimeSubtract;
        public bool divisionOrNot;
        public bool multiplyOrNot;
        public bool addOrNot;
        public bool subtractOrNot;
        public decimal valueOperatedOn;
        public decimal operationValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outputBox.Text = "0";
            this.CenterToScreen();

        }

        //this method tells whether there is a 0 in the outputBox
        //this is important because we can't add values like 0111 because it starts with 0 (just doing this because that's just how normal calculators work)
        private bool replaceZeroOrNot()
        {
            if (outputBox.Text == "0")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn0.Text;
            }
            else
            {
                outputBox.Text += btn0.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn1.Text;
            }
            else
            {
                outputBox.Text += btn1.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn2.Text;
            }
            else
            {
                outputBox.Text += btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn3.Text;
            }
            else
            {
                outputBox.Text += btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn4.Text;
            }
            else
            {
                outputBox.Text += btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn5.Text;
            }
            else
            {
                outputBox.Text += btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn6.Text;
            }
            else
            {
                outputBox.Text += btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn7.Text;
            }
            else
            {
                outputBox.Text += btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn8.Text;
            }
            else
            {
                outputBox.Text += btn8.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (replaceZeroOrNot())
            {
                outputBox.Text = btn9.Text;
            }
            else
            {
                outputBox.Text += btn9.Text;
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (!outputBox.Text.Contains("."))
            {
                outputBox.Text += btnPeriod.Text;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            outputBox.Text = "0";
            firstOrSecondTimeDivision = 0;
            firstOrSecondTimeMultiply = 0;
            firstOrSecondTimeAdd = 0;
            firstOrSecondTimeSubtract = 0;
            operationValue = 0;
            valueOperatedOn = 0;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstOrSecondTimeDivision++;
            divisionOrNot = false;
            multiplyOrNot = false;
            addOrNot = false;
            subtractOrNot = false;
            valueOperatedOn = 0;
            operationValue = 0;
            if (firstOrSecondTimeDivision == 1)
            {
                if (!outputBox.Text.Contains("."))
                {
                    valueOperatedOn = int.Parse(outputBox.Text);
                }
                else
                {
                    valueOperatedOn = decimal.Parse(outputBox.Text);
                }
                divisionOrNot = true;
                outputBox.Text = "0";
            }
            else if (firstOrSecondTimeDivision == 2)
            {
                firstOrSecondTimeDivision = 0;
                valueOperatedOn = decimal.Parse(outputBox.Text);
                divisionOrNot = true;
                outputBox.Text = "0";
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstOrSecondTimeMultiply++;
            divisionOrNot = false;
            multiplyOrNot = false;
            addOrNot = false;
            subtractOrNot = false;
            valueOperatedOn = 0;
            operationValue = 0;
            if (firstOrSecondTimeMultiply == 1)
            {
                if (!outputBox.Text.Contains("."))
                {
                    valueOperatedOn = int.Parse(outputBox.Text);
                }
                else
                {
                    valueOperatedOn = decimal.Parse(outputBox.Text);
                }
                multiplyOrNot = true;
                outputBox.Text = "0";
            }
            else if (firstOrSecondTimeMultiply == 2)
            {
                firstOrSecondTimeMultiply = 0;
                valueOperatedOn = decimal.Parse(outputBox.Text);
                multiplyOrNot = true;
                outputBox.Text = "0";
            }
            else
            {
                firstOrSecondTimeMultiply = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstOrSecondTimeAdd++;
            divisionOrNot = false;
            multiplyOrNot = false;
            addOrNot = false;
            subtractOrNot = false;
            valueOperatedOn = 0;
            operationValue = 0;
            if (firstOrSecondTimeAdd == 1)
            {
                if (!outputBox.Text.Contains("."))
                {
                    valueOperatedOn = int.Parse(outputBox.Text);
                }
                else
                {
                    valueOperatedOn = decimal.Parse(outputBox.Text);
                }
                addOrNot = true;
                outputBox.Text = "0";
            }
            else if (firstOrSecondTimeAdd == 2)
            {
                firstOrSecondTimeAdd = 0;
                valueOperatedOn = decimal.Parse(outputBox.Text);
                addOrNot = true;
                outputBox.Text = "0";
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            firstOrSecondTimeSubtract++;
            divisionOrNot = false;
            multiplyOrNot = false;
            addOrNot = false;
            subtractOrNot = false;
            valueOperatedOn = 0;
            operationValue = 0;
            if (firstOrSecondTimeSubtract == 1)
            {
                if (!outputBox.Text.Contains("."))
                {
                    valueOperatedOn = int.Parse(outputBox.Text);
                }
                else
                {
                    valueOperatedOn = decimal.Parse(outputBox.Text);
                }
                subtractOrNot = true;
                outputBox.Text = "0";
            }
            else if (firstOrSecondTimeSubtract == 2)
            {
                firstOrSecondTimeSubtract = 0;
                valueOperatedOn = decimal.Parse(outputBox.Text);
                subtractOrNot = true;
                outputBox.Text = "0";
            }
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (divisionOrNot == true)
            {
                outputBox.Text = (valueOperatedOn / decimal.Parse(outputBox.Text)).ToString("C", CultureInfo.CurrentCulture);
                divisionOrNot = false;
                multiplyOrNot = false;
                subtractOrNot = false;
                addOrNot = false;
                valueOperatedOn = 0;
                operationValue = 0;
            }
            else if (multiplyOrNot == true)
            {
                outputBox.Text = (valueOperatedOn * decimal.Parse(outputBox.Text)).ToString("C", CultureInfo.CurrentCulture);
                divisionOrNot = false;
                multiplyOrNot = false;
                subtractOrNot = false;
                addOrNot = false;
                valueOperatedOn = 0;
                operationValue = 0;
            }
            else if (addOrNot == true)
            {
                outputBox.Text = (valueOperatedOn + decimal.Parse(outputBox.Text)).ToString("C", CultureInfo.CurrentCulture);
                divisionOrNot = false;
                multiplyOrNot = false;
                subtractOrNot = false;
                addOrNot = false;
                valueOperatedOn = 0;
                operationValue = 0;
            }
            else if (subtractOrNot == true)
            {
                outputBox.Text = (valueOperatedOn - decimal.Parse(outputBox.Text)).ToString("C", CultureInfo.CurrentCulture);
                divisionOrNot = false;
                multiplyOrNot = false;
                subtractOrNot = false;
                addOrNot = false;
                valueOperatedOn = 0;
                operationValue = 0;
            }
        }

        //Compound interest formula: A = P*(1+(r/n))^(nt)
        //Compound interest formula: A = the initial value * (1 + (rate / (the frequency per year))^(frequency per year * amount of years)
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int dotIndex = txtDollars.Text.IndexOf('.');
            try
            {
                if (txtDollars.Text.Contains(".")) {
                    if (dotIndex != -1 && dotIndex + 3 == txtDollars.Text.Length)
                    {
                        calculateMethod();
                    }
                    else {
                        MessageBox.Show("Not correct format!");
                        cmpdOutput.Text = "";
                    }
                } else {
                    calculateMethod();
                }
            } catch (FormatException)
            {
                MessageBox.Show("Wrong Input.");
            }
        }

        private void calculateMethod() 
        {
            int dotIndex = txtDollars.Text.IndexOf('.');

            if (rdoMonthly.Checked)
            {
                decimal principal = decimal.Parse(txtDollars.Text);
                decimal interestRate = decimal.Parse(txtInterest.Text);
                int years = int.Parse(txtYears.Text);
                double compoundedAmount = (double)principal * Math.Pow(1 + (double)(interestRate / 100 / 12), 12 * years);
                cmpdOutput.Text = ((decimal)compoundedAmount).ToString("C", CultureInfo.CurrentCulture);
            }
            else if (rdoQtr.Checked)
            {
                decimal principal = decimal.Parse(txtDollars.Text);
                decimal interestRate = decimal.Parse(txtInterest.Text);
                int years = int.Parse(txtYears.Text);
                double compoundedAmount = (double)principal * Math.Pow(1 + (double)(interestRate / 100 / 4), 4 * years);
                cmpdOutput.Text = ((decimal)compoundedAmount).ToString("C", CultureInfo.CurrentCulture);
            }
            else if (rdoSemi.Checked)
            {
                decimal principal = decimal.Parse(txtDollars.Text);
                decimal interestRate = decimal.Parse(txtInterest.Text);
                int years = int.Parse(txtYears.Text);
                double compoundedAmount = (double)principal * Math.Pow(1 + (double)(interestRate / 100 / 2), 2 * years);
                cmpdOutput.Text = ((decimal)compoundedAmount).ToString("C", CultureInfo.CurrentCulture);
            }
            else
            {
                decimal principal = decimal.Parse(txtDollars.Text);
                decimal interestRate = decimal.Parse(txtInterest.Text);
                int years = int.Parse(txtYears.Text);
                double compoundedAmount = (double)principal * Math.Pow(1 + (double)(interestRate / 100), years);
                cmpdOutput.Text = ((decimal)compoundedAmount).ToString("C", CultureInfo.CurrentCulture);
            }

        }
    }
}
