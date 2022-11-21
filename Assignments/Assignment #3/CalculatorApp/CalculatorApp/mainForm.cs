using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class mainForm : Form
    {
        //Properties
        //ArrayList values = new ArrayList();
        List<string> values = new List<string>();
        string[] operators = { "/", "*", "+", "-"};
        string operation = "";
        double result = 0;
        bool isResult = false;


        public mainForm()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "0";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "0";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "0";
            }

            isResult = false;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "1";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "1";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "1";
            }

            isResult = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "2";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "2";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "2";
            }

            isResult = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "3";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "3";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "3";
            }

            isResult = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "4";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "4";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "4";
            }

            isResult = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "5";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "5";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "5";
            }

            isResult = false;
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "6";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "6";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "6";
            }

            isResult = false;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "7";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "7";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "7";
            }

            isResult = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "8";
            }
            else if (isResult)
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "8";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "8";
            }

            isResult = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text == "0" || operators.Contains(textBoxResults.Text))
            {
                //add num value to textbox
                textBoxResults.Text = "9";
            }
            else if (isResult) 
            {
                values.Clear();
                result = 0;

                //add num value to textbox
                textBoxResults.Text = "9";
            }
            else
            {
                //add num value to textbox
                textBoxResults.Text += "9";
            }

            isResult = false;
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {

            if (!operators.Contains(textBoxResults.Text) && !isResult)
            {
                //add decimal to textbox
                textBoxResults.Text += ".";
            }
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            if (operators.Contains(textBoxResults.Text))
                return;

            if (!isResult)
                values.Add(textBoxResults.Text);

            textBoxResults.Text = "/";
            values.Add(textBoxResults.Text);
        }
        private void butMult_Click(object sender, EventArgs e)
        {
            if (operators.Contains(textBoxResults.Text))
                return;

            if (!isResult)
                values.Add(textBoxResults.Text);

            textBoxResults.Text = "*";
            values.Add(textBoxResults.Text);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (operators.Contains(textBoxResults.Text))
                return;

            if (!isResult)
                values.Add(textBoxResults.Text);

            textBoxResults.Text = "+";
            values.Add(textBoxResults.Text);
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            if (operators.Contains(textBoxResults.Text))
                return;

            if (!isResult)
                values.Add(textBoxResults.Text);

            textBoxResults.Text = "-";
            values.Add(textBoxResults.Text);
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (operators.Contains(textBoxResults.Text))
                return;

            values.Add(textBoxResults.Text);
            result = double.Parse(values[0]);

            for (int i = 0; i < values.Count; i++)
            {
                if (operators.Contains(values[i])) 
                {
                    operation = values[i];

                    switch (operation)
                    {
                        case "+":
                            result += double.Parse(values[i+1]);
                            break;
                        case "-":
                            result -= double.Parse(values[i+1]);
                            break;
                        case "*":
                            result *= double.Parse(values[i+1]);
                            break;
                        case "/":
                            result /= double.Parse(values[i+1]);
                            break;
                    }
                }
            }
            
            textBoxResults.Text = result.ToString();

            isResult = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = "0";
            values.Clear();
            result = 0;
            isResult = false;
        }
        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = "0";

            if (isResult) 
            {
                values.Clear();
                result = 0;
                isResult = false;
            }
        }

        private void plusMinusBtn_Click(object sender, EventArgs e)
        {
            if (textBoxResults.Text != "0" && !operators.Contains(textBoxResults.Text) && !isResult) 
            {
                double reversed;
                reversed = double.Parse(textBoxResults.Text) * -1;
                textBoxResults.Text = reversed.ToString();   
            }
        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {
            if (!operators.Contains(textBoxResults.Text))
            {
                if (isResult)
                {
                    textBoxResults.Text = "0";
                    values.Clear();
                    result = 0;
                    isResult = false;
                }
                else 
                {
                    textBoxResults.Text = textBoxResults.Text.Remove(0, 1);

                    if (textBoxResults.Text.Length == 0)
                        textBoxResults.Text = "0";
                }
            }
        }
    }
}
