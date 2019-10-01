using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laskin1
{
    public partial class Form1 : Form
    {
        static string a;
        static char x;
        static string filepath = "C:/Users/Rotte/Documents/VS_Test/Laskin1.txt";
        public Form1()
        {
            
            InitializeComponent();
            TextWriter tw = new StreamWriter(filepath, true);
            tw.WriteLine("Ohjelma käynnistyi: " + DateTime.Now);
            tw.Close();
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filepath = "C:/Users/Rotte/Documents/VS_Test/Laskin1.txt";
            TextWriter tw = new StreamWriter(filepath, true);
            tw.WriteLine("Ohjelma sammui Menun kautta: " + DateTime.Now);
            tw.Close();
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            if(textBox_Result.Text == "0")
            {
                textBox_Result.Clear();
            }
            button_plus.Enabled = true;
            button_jako.Enabled = true;
            button_minus.Enabled = true;
            button_kerto.Enabled = true;
            button2.Enabled = true;
            Button button = (Button)sender;
            textBox_Result.Text = textBox_Result.Text + button.Text;
            textBox2.Text = textBox2.Text + button.Text;
            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
           
            a = textBox_Result.Text;
            textBox_Result.Clear();
            Button op = (Button)sender;
            x = char.Parse(op.Text);
            if (textBox2.Text.EndsWith("+"))
            {
                button_plus.Enabled = false;
                
            }
            else if (textBox2.Text.EndsWith("-"))
            {
                button_minus.Enabled = false;
                
            }
            else if (textBox2.Text.EndsWith("*"))
            {
                button_kerto.Enabled = false;
               
            }
            else if (textBox2.Text.EndsWith("/"))
            {
                button_jako.Enabled = false;

            }
            else
            {
                textBox2.Text = textBox2.Text + op.Text;
            }
            
            
            
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            textBox2.Clear();    
            textBox_Result.Clear();
        }

        private void Button18_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            decimal result = 0;
            string resultS;
            decimal luku = 0;
            try
            {
                luku = decimal.Parse(textBox_Result.Text);
            }
            catch(FormatException )
            {
                textBox_Result.Text = "Error";
            }
            decimal a0 = decimal.Parse(a);
            textBox_Result.Clear();
            switch (x)
            {
                
                case '+':
                    result = a0 + luku;
                    resultS = result.ToString();
                    textBox_Result.Text = resultS;
                    break;
                case '-':
                    result = a0 - luku;
                    resultS = result.ToString();
                    textBox_Result.Text = resultS;
                    break;
                case '/':
                    try
                    {
                        result = a0 / luku;
                    }
                    catch (DivideByZeroException)
                    {
                        textBox_Result.Clear();
                        textBox_Result.Text = "You Created a Black Hole!";
                        break;
                    }
                    resultS = result.ToString();
                    textBox_Result.Text = resultS;
                    break;
                case '*':
                    result = a0 * luku;
                    resultS = result.ToString();
                    textBox_Result.Text = resultS;
                    break;
                default: textBox_Result.Text = "Error" ;
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            TextWriter tw = new StreamWriter(filepath, true);
            tw.WriteLine("Ohjelma Sammui: " + DateTime.Now);
        }
    }    
}
