using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Calc
{
    public partial class Form1 : Form
    {
        double ans = 0, num1 = 0, num2 = 0;
        bool is_num1_init=false, is_num2_init=false;
        String op = "", point = "", temp1="", temp2="";

        private void button4_Click(object sender, EventArgs e)
        {
            int value = 4;
            
            result_bar_text(value);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int value = 5;
            
            result_bar_text(value);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int value = 6;
            
            result_bar_text(value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int value = 7;
            
            result_bar_text(value);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int value = 8;
            
            result_bar_text(value);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int value = 9;
            
            result_bar_text(value);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int value = 0;
            
            result_bar_text(value);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            point = ".";
            if (!is_num1_init)                           //n1=_ and n2=_
            {
                textBox1.Text = "0.";
                return;
            }
            else
            if (is_num1_init && op == "" && !num1.ToString().Contains("."))                 //n1=x_ and n2=_       
            {
                textBox1.Text += ".";
                return;
            }
            else
            if (op != "" && !is_num2_init)                //n1=xx and n2=_
            {
                textBox1.Text += "0.";
                return;
            }
            else
            if (op != "" && is_num2_init && !num2.ToString().Contains("."))               //n1=xx and n2=y_
            {
                textBox1.Text += ".";
                return;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (!textBox1.Text.Contains("+") || !textBox1.Text.Contains("-") || !textBox1.Text.Contains("/") || !textBox1.Text.Contains("*"))
            {
                op = "+";
                textBox1.Text += " " + op + " ";
            }
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Contains("+") || !textBox1.Text.Contains("-") || !textBox1.Text.Contains("/") || !textBox1.Text.Contains("*"))
            {
                op = "*";
                textBox1.Text += " " + op + " ";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Contains("+") || !textBox1.Text.Contains("-") || !textBox1.Text.Contains("/") || !textBox1.Text.Contains("*"))
            {
                op = "/";
                textBox1.Text += " " + op + " ";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            if (!textBox1.Text.Contains("+") || !textBox1.Text.Contains("-") || !textBox1.Text.Contains("/") || !textBox1.Text.Contains("*"))
            {
                op = "-";
                textBox1.Text += " " + op + " ";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
                if (!is_num1_init)
                    ans = 0;
                else
                if (is_num1_init && op=="")
                {
                    ans = num1;
                } 
                else
                if (is_num1_init && op!="" && !is_num2_init)
                {
                    ans = num1;
                }
                else
                {
                    if (num2 == 0 && op == "/")
                    {
                        textBox1.Text = "Undefined";
                        ans = 0;
                        return;
                    }
                    else
                    {
                        switch (op)
                        {
                            case "+": 
                                ans = num1 + num2;
                                break;
                                
                            case "*":
                                ans = num1 * num2;
                                break;
                               
                            case "/":
                                ans = num1 / num2;
                                break;
                                
                            case "-":
                                ans = num1 - num2;
                            
                                break;

                        }
                    }

                }
                textBox1.Text = ans.ToString();
                num1 = ans;
                temp1 = num1.ToString();
                num2 = 0;
                temp2 = num2.ToString();
                op = "";
                is_num1_init = true;
                is_num2_init = false;
                ans = 0;
            
        }

        private void button17_Click(object sender, EventArgs e)
        {
                is_num1_init = false;
                is_num2_init = false;
                temp1 = "";
                temp2 = "";
                ans = 0;
                num1 = 0;
                num2 = 0;
                op = "";
                textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int value = 3;
            
            result_bar_text(value);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int value = 2;
            
            result_bar_text(value);
        }

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = ans.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(!label1.Text.Contains(":)"))
                label1.Text += ":)";
        }

        private void result_bar_text(int value)
        {
            bool is_point = false;
            if (point == ".")
                is_point = true;
            if (!is_num1_init)                           //n1=_ and n2=_
            {
                if(is_point==true)
                {
                    temp1 = "0." + value.ToString();
                    num1 = Convert.ToDouble(temp1);
                    point = "";
                }
                else
                {
                    num1 = value;
                    temp1 = num1.ToString();
                }
                
                is_num1_init = true;
                textBox1.Text = num1.ToString();
                return;
            }
            else
            if (is_num1_init && op == "")                 //n1=x_ and n2=_       
            {
                if (is_point == true)
                {
                    if (!temp1.Contains("."))
                    {
                        temp1 += "." + value.ToString();
                        num1 = Convert.ToDouble(temp1);
                    }
                    point = "";
                }
                else
                {
                    temp1 += value.ToString();
                    num1 = Convert.ToDouble(temp1);
                }
                
                textBox1.Text = num1.ToString();
                return;
            }
            else
            if (op != "" && !is_num2_init)                //n1=xx and n2=_
            {
                if (is_point == true)
                {
                    temp2 = "0." + value.ToString();
                    num2 = Convert.ToDouble(temp2);
                    point = "";
                   
                }
                else
                {
                    num2 = value;
                    temp2 = num2.ToString();
                }
                
                is_num2_init = true;
                textBox1.Text = "";
                textBox1.Text += num1.ToString() + " " + op + " " + num2.ToString();
                return;
            }
            else
            if (op != "" && is_num2_init)               //n1=xx and n2=y_
            {
                if (is_point == true)
                {
                    if (!temp2.Contains("."))
                    {
                        temp2 += "." + value.ToString();
                        num2 = Convert.ToDouble(temp2);
                    }
                    point = "";
                }
                else
                {
                    temp2 += value.ToString();
                    num2 = Convert.ToDouble(temp2);
                }
                
                textBox1.Text = "";
                textBox1.Text += num1.ToString() + " " + op + " " + num2.ToString();
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value = 1;
            
            result_bar_text(value);
        }
    }
}
