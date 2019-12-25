using System;
using System.Windows.Forms;

namespace Calculator.v2
{
    public partial class Form1 : Form
    {
        Double result = 0;
        String operation = "";
        bool enter_value = false;
        String firstnum, secondnum;

        public Form1()
        {
            InitializeComponent();
        }

        // Numpad
        private void numbers_Only(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if ((txtDisplay.Text == "0") || (enter_value == true))
            {
                txtDisplay.Text = "";
            }
            else
            {
                //enter_value = false;
            }


            // When user presses Decimal button
            if (b.Text == ".")
            {
                if (!txtDisplay.Text.Contains("."))
                {
                    txtDisplay.Text += b.Text;
                }
                else
                {
                    txtDisplay.Text += b.Text;
                }
            }

            else
            {
                txtDisplay.Text += b.Text;
            }

        }

        private void operators_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (result != 0)
            {
                btnEquals.PerformClick();
                enter_value = true;
                operation = b.Text;
                lblOperator.Text = result + operation;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(txtDisplay.Text);
                txtDisplay.Text = "";
                lblOperator.Text = result + operation;

            }

            firstnum = lblOperator.Text;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            secondnum = txtDisplay.Text;
            lblOperator.Text = "";

            switch (operation)
            {
                case "+":
                    txtDisplay.Text = (result + Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "-":
                    txtDisplay.Text = (result - Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "*":
                    txtDisplay.Text = (result * Double.Parse(txtDisplay.Text)).ToString();
                    break;
                case "/":
                    txtDisplay.Text = (result / Double.Parse(txtDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = Double.Parse(txtDisplay.Text);
            operation = "";

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            lblOperator.Text = "";
            result = 0;
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 1)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);
            }
            else if (txtDisplay.Text.Length == 1)
            {
                txtDisplay.Text = "0";
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}