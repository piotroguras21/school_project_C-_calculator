using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string pierwszaliczba, drugaliczba;
        char rodzajdzialania = ' ';


        private void tbwynik_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void bdodawanie_Click(object sender, EventArgs e)
        {
            rodzajdzialania = '+';
            tbwynik.Text = "";
        }

        private void bodejmowanie_Click(object sender, EventArgs e)
        {
            rodzajdzialania = '-';
            tbwynik.Text = "";
        }

        private void bmnozenie_Click(object sender, EventArgs e)
        {
            rodzajdzialania = '*';
            tbwynik.Text = "";
        }

        private void bdzielenie_Click(object sender, EventArgs e)
        {
            rodzajdzialania = '/';
            tbwynik.Text = "";
        }

        private void bwynik_Click(object sender, EventArgs e)
        {
            try
            {
                switch (rodzajdzialania)
                {
                    case ('+'):
                        tbwynik.Text = (int.Parse(pierwszaliczba) + int.Parse(drugaliczba)).ToString();
                        break;
                    case ('-'):
                        tbwynik.Text = (int.Parse(pierwszaliczba) - int.Parse(drugaliczba)).ToString();
                        break;
                    case ('*'):
                        tbwynik.Text = (int.Parse(pierwszaliczba) * int.Parse(drugaliczba)).ToString();
                        break;
                    case ('/'):
                        if (drugaliczba == "0") MessageBox.Show("Error: You can't devide by zero!");
                        else tbwynik.Text = (int.Parse(pierwszaliczba) / int.Parse(drugaliczba)).ToString();
                        break;
                }
                pierwszaliczba = tbwynik.Text;
                drugaliczba = "";
                rodzajdzialania = ' ';
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: It's not a number!");
                MessageBox.Show(exp.Message);
            }

        }


        private void b0_Click(object sender, EventArgs e)
        {
            dzialanie(0);
        }

        private void b1_Click(object sender, EventArgs e)
        {
            dzialanie(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            dzialanie(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            dzialanie(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            dzialanie(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            dzialanie(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            dzialanie(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            dzialanie(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            dzialanie(9);
        }

        private void dzialanie(int liczba)
        {
            if (rodzajdzialania == ' ')
            {
                pierwszaliczba += liczba;
                tbwynik.Text = pierwszaliczba;
            }
            else
            {
                drugaliczba += liczba;
                tbwynik.Text = drugaliczba;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pierwszaliczba = "";
            drugaliczba = "";
            rodzajdzialania = ' ';
            tbwynik.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Dvd6kcOMa8w");
        }
      


       

        
    }
}
