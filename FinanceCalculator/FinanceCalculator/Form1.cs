namespace FinanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            Button[] numberButtons = new Button[10];
            numberButtons[0] = btn0;
            numberButtons[1] = btn1;
            numberButtons[2] = btn2;
            numberButtons[3] = btn3;
            numberButtons[4] = btn4;
            numberButtons[5] = btn5;
            numberButtons[6] = btn6;
            numberButtons[7] = btn7;
            numberButtons[8] = btn8;
            numberButtons[9] = btn9;
        }

        private bool replaceZeroOrNot()
        {
            if (outputBox.Text == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
