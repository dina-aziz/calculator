using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string op1="";
        string op2="";
        int openBr = 0;
        int clBr = 0;
        string operation;
        string result="0";
        bool prevIsNum = false;
        bool prevIsOper = true;
        bool prevRtBrkt = false;
        bool prevIsDot = false;
        bool bropen = false;
        bool noDec = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "1";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "9";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "3";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button_rightbr_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (openBr-clBr>0)
            {
                //out_screen.Text += ")";
                if (out_screen.Text == "" || prevIsNum ||prevRtBrkt) out_screen.Text += ")";
                prevIsOper = false;
                prevIsNum = false;
                prevRtBrkt = true;
                clBr++;
            }
            bropen = false;
            prevRtBrkt = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int  displayValue = 0;
            out_screen.Text = displayValue.ToString();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if ((out_screen.Text != "0" && prevIsNum) || prevRtBrkt)
            {
                out_screen.Text += "+";
                prevIsOper = true;
                prevIsNum = false;
                prevRtBrkt = false;
                noDec = false;
            }
        }

        private void button_equal_Click(object sender, EventArgs e)
        {
            string expr = out_screen.Text;
            Solver s1 = new Solver(expr);
            s1.solve();
            out_screen.Text = s1.Sol.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            out_screen.Text = "0";
            op1 = "";
            op2 = "";
            openBr = 0;
            clBr = 0;
            result = "0";
            prevIsNum = false;
            prevIsOper = true;
            prevRtBrkt = false;
            prevIsDot = false;
            bropen = false;
            noDec = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "2";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "4";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "5";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "6";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot)
                {
                    out_screen.Text += "7";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot)
            {
                out_screen.Text += "8";
                prevIsNum = true;
                prevIsOper = false;
                prevIsDot = false;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (prevIsOper || prevIsNum || prevIsDot) 
                {
                    out_screen.Text += "0";
                    prevIsNum = true;
                    prevIsOper = false;
                    prevIsDot = false;
                }
        }

        private void button_leftbr_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (out_screen.Text == "" || prevIsOper)
            {
                out_screen.Text += "(";
                openBr++;
            }
        }

        private void button_dot_Click(object sender, EventArgs e)
        {
            if (out_screen.Text == "0")
                out_screen.Text = "";
            if (out_screen.Text == "" ) out_screen.Text += "0.";
            else if (prevIsNum && !noDec) out_screen.Text += ".";
            prevIsOper = false;
            prevIsNum = false;
            prevIsDot = true;
            noDec = true;
        }

        private void button_mult_Click(object sender, EventArgs e)
        {
            if ((out_screen.Text != "0" && prevIsNum) || prevRtBrkt)
            {
                out_screen.Text += "*";
                prevIsOper = true;
                prevIsNum = false;
                prevRtBrkt = false;
                noDec = false;
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if ((out_screen.Text != "0" && prevIsNum) || prevRtBrkt)
            {
                out_screen.Text += "-";
                prevIsOper = true;
                prevIsNum = false;
                prevRtBrkt = false;
                noDec = false;
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            if ((out_screen.Text != "0" && prevIsNum) || prevRtBrkt)
            {
                out_screen.Text += "/";
                prevIsOper = true;
                prevIsNum = false;
                prevRtBrkt = false;
                noDec = false;
            }
        }

        private void button_bkspace_Click(object sender, EventArgs e)
        {
            int len=out_screen.Text.Length;
            string del = out_screen.Text.Substring(len-1,1);
            if(len>1)out_screen.Text = out_screen.Text.Substring(0, len - 1);
            if (len == 1) out_screen.Text = "0";
            if (del =="(") openBr--;
            if (del == ")") clBr--;

        }
    }
}
