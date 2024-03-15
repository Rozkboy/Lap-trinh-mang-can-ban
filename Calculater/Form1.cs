using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (textbox_Result.Text == "0" || (isOperationPerformed))
                textbox_Result.Clear();
            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textbox_Result.Text.Contains("."))
                    textbox_Result.Text = textbox_Result.Text + button.Text;

            }
            else
                textbox_Result.Text = textbox_Result.Text + button.Text;
        }

        private void operater_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button21.PerformClick();
                operationPerformed = button.Text;
                resultValue = Double.Parse(textbox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textbox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void deleteentry_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
        }

        private void deleteall_Click(object sender, EventArgs e)
        {
            textbox_Result.Text = "0";
            resultValue = 0;
        }


        private void percentButton_Click(object sender, EventArgs e)
        {
            double inputValue = double.Parse(textbox_Result.Text);
            double percentResult = inputValue / 100;

            textbox_Result.Text = percentResult.ToString();
        }



        private void bang_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textbox_Result.Text = (resultValue + Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "-":
                    textbox_Result.Text = (resultValue - Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "*":
                    textbox_Result.Text = (resultValue * Double.Parse(textbox_Result.Text)).ToString();
                    break;
                case "/":
                    textbox_Result.Text = (resultValue / Double.Parse(textbox_Result.Text)).ToString();
                    break;

                default:
                    break;

            }
            resultValue = Double.Parse(textbox_Result.Text);
            labelCurrentOperation.Text = "";

        }
    }
}


        
