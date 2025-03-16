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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { // form1
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String enter = textBox1.Text.Replace(" ", "").Replace("×", "*").Replace("÷", "/");
            Double result = 0; 
            if (enter.Contains("+")  || enter.Contains("-") ||  enter.Contains("*") ||  enter.Contains("/"))
            { 
                int  index = -1;
                Char operatorUsed = ' '; 
                for (int x = 0; x < enter.Length; x++)
                {
                    if (enter[x] == '+' ||  enter[x] == '-' ||  enter[x] == '*'  || enter[x] == '/')
                    {
                         index =x;
                        operatorUsed = enter[x];
                        break;

                    }
                }
                  if (index != -1)
                { 
                      Double number1 = Convert.ToDouble(enter.Substring(0,  index));
                      Double number2 = Convert.ToDouble(enter.Substring( index + 1)); 
                    switch (operatorUsed)
                    {
                        case '+':
                            result = number1 + number2;
                            break;
                        case  '*':
                            result = number1 + number2;
                            break; 
                        case '/':
                            if (number2 == 0)
                            {
                                MessageBox.Show("Can't be divided by 0");
                                return;
                            }
                            result = number1 / number2;
                            break;
                            case '-':
                            result = number1 + number2;
                            break;
                    }

                    textBox1.Text = result.ToString(); 
                    return;
                }
            }
              
            if (enter.StartsWith("sin") || enter.StartsWith("cos") || enter.StartsWith("tan"))
            {// Three trigonometic functions
                String function = enter.Substring(0, 3);  
                String angleText = enter.Substring(3); 
                { 
                    Double angle = Convert.ToDouble(angleText); 
                    Double Radians = angle * Math.PI / 180; 
                    Double output = 0; 
                    //angle in radian
                    if (function == "sin") output  = Math.Sin(Radians);
                    else if (function == "cos") output  = Math.Cos(Radians);
                    else if (function == "tan") output  = Math.Tan(Radians); 
                    textBox1.Text = output .ToString();  
                }
                
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("+");


        }


        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

            textBox1.Text += "cos";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Double squ = Convert.ToDouble(textBox1.Text);
            squ = Math.Sqrt(squ);
            textBox1.Text = Convert.ToString(squ); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            //textbox1
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Double i;
            i = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(i);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Double x = Convert.ToDouble(textBox1.Text);
            if (x == 0)
            {
                MessageBox.Show("Cannot divide by zero!");   
            }
            else
            {
                Double result = 1 / x;   
                textBox1.Text = "1/x " + x + "=" + result;
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Double value = Double.Parse(textBox1.Text); 
            value = -value; 
            textBox1.Text = value.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double log = Convert.ToDouble(textBox1.Text);
            log = Math.Log10(log);
            textBox1.Text = Convert.ToString(log);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Double x;
            Double numnber = Convert.ToDouble(textBox1.Text);
            x = numnber * numnber * numnber;   
            textBox1.Text = Convert.ToString(x); 

        }

        private void button13_Click(object sender, EventArgs e)
        {

            textBox1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {

            textBox1.Text += "2";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("-");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("÷");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += ("×");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(")"))
            {

                textBox1.Text += ")";

            }

        }

        private void button26_Click(object sender, EventArgs e)
        {

            if (!textBox1.Text.Contains("("))
            {

                textBox1.Text += "(";

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {

            textBox1.Text += "sin";
             
             

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "3.14159265359";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = ("tan");
        }

        private void button24_Click(object sender, EventArgs e)
        {

            Double value = Double.Parse(textBox1.Text); 
            Double result = value / 100; 
           textBox1.Text = result.ToString();

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Double Antilog = Convert.ToDouble(textBox1.Text);
            Antilog = Math.Pow(10,Antilog);
            textBox1.Text = Convert.ToString(Antilog);
        }

        static long factorial(int x)
        {
            long final = 1;
            for (int n = 1; n <= x; n++)
            {
                final *= n;
            }
            return final;
        }
        private void button31_Click(object sender, EventArgs e)
        {

            int x = int.Parse(textBox1.Text);
            long final = factorial(x);
            textBox1.Text = "factorial of "+ x + "is" + final;
 
        }

        
    }
}
