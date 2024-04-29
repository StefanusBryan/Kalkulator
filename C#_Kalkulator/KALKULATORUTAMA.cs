using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KALKULATOR
{
    public partial class KALKULATORUTAMA : Form
    {
        MyCalc MyCalculator;

        string opr;
        double angka1;
        double angka2;
        double hasil;
        double angka3;
        double angka4;
        double hasil2;

        int operasioperasi = 0;

        bool equalditekan;
        bool plusminusdivmul;


        public KALKULATORUTAMA()
        {
            InitializeComponent();
            MyCalculator = new MyCalc();

            equalditekan = false;
            plusminusdivmul = false;
        }

        private void button0_Click(object sender, EventArgs e) //ANGKA
        {
            if (equalditekan)
            {
                textBox.Text = "";
                textBox2.Text = "";
                angka1 = 0;
                angka2 = 0;
            }

            String nr = ((Button)sender).Text;
            if (!(textBox.Text == "0" && nr == "0"))
            {
                textBox.Text += nr;
            }


            equalditekan = false;
        }


        private void buttonplus_Click(object sender, EventArgs e) //OPERASI
        {
            if (equalditekan)
            {
                
            }
            else
            {
                if (textBox.Text.Length > 0)
                {
                    angka2 = Double.Parse(textBox.Text);
                    angka1 = MyCalculator.calc(angka1, opr, angka2);
                    angka2 = 0;
                    textBox2.Text = angka1.ToString();
                }
                if (textBox.Text == "")
                {
                    if (operasioperasi == 1)
                    {
                        opr = ((Button)sender).Text;
                        textBox3.Text = opr;
                    }
                }

                else
                {
                    opr = ((Button)sender).Text;

                    if (operasioperasi == 0)
                    {
                        operasioperasi = 1;
                        angka1 = Double.Parse(textBox.Text);
                    }
                    else
                    {
                    }
                    textBox.Text = "";
                    textBox2.Text = angka1.ToString();
                    textBox3.Text = opr;
                }
            }
            
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            

            if (equalditekan)
            {
                angka3 = Double.Parse(textBox.Text);
                hasil2 = MyCalculator.calc(angka3, opr, angka4);
                textBox.Text = hasil2.ToString();
            }
            else
            {
                if (textBox.Text == "")
                {

                }
                else
                {
                    angka2 = Double.Parse(textBox.Text);

                    hasil = MyCalculator.calc(angka1, opr, angka2);
                    textBox.Text = hasil.ToString();
                    textBox3.Text = "";
                    textBox2.Text = "";
                    angka4 = angka2;
                    angka1 = 0;
                    angka2 = 0;
                    operasioperasi = 0;

                    equalditekan = true;
                }
            }
            
            
        }

        

        private void buttondot_Click(object sender, EventArgs e)
        {
            
            if (textBox.Text == "")
            {
                textBox.Text = "";
            }
            else if (!textBox.Text.Contains("."))
            {
                textBox.Text += (".");
            }
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            angka1 = 0;
            angka2 = 0;
            operasioperasi = 0;
        }

        private void buttonce_Click(object sender, EventArgs e)
        {
            if (angka1 > 0 && angka2 == 0)
            {
                textBox.Text = "";
            }
            else if (angka1 == 0 && angka2 == 0)
            {
                textBox.Text = "";
            }
        }
    }
}
