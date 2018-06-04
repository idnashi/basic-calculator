using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Calculator : Form
    {
        private bool isOperation = false;
        private Double result = 0;
        private string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, EventArgs e)
        {
            if (textBox_result.Text == "0" || isOperation)
                textBox_result.Clear();

            isOperation = false;

            Button button = (Button) sender;

            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                    textBox_result.Text += button.Text;
            }
            else
                textBox_result.Text += button.Text;
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;

            if (result != 0)
                button_equal.PerformClick();
            else
                result = Double.Parse(textBox_result.Text);

            isOperation = true;
            operation = button.Text;
            history.Text = result + " " + operation;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            result = 0;
        }

        private void Equate_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    textBox_result.Text = (result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (result / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = Double.Parse(textBox_result.Text);
            history.Text = "";
        }
    }
}
