using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuş_Kombinasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool tuş1, tuş2;

        string kelime;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.ControlKey)
            {
                tuş1 = true;
            }

            if (e.KeyCode==Keys.R)
            {
                tuş2 = true;
            }

            if (tuş1==true && tuş2==true)
            {
                kelime = string.Copy(textBox1.Text);
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                tuş1 = false;
            }

            if (e.KeyCode == Keys.R)
            {
                tuş2 = false;
            }

            if (tuş1 == false && tuş2 == false)
            {
               
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                tuş1 = true;
            }

            if (e.KeyCode == Keys.T)
            {
                tuş2 = true;
            }

            if (tuş1 == true && tuş2 == true)
            {
                if (kelime!="")
                {
                    textBox3.Text = kelime;
                }

                else
                {
                    textBox3.Paste();
                }
                
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                tuş1 = false;
            }

            if (e.KeyCode == Keys.T)
            {
                tuş2 = false;
            }

            if (tuş1 == false && tuş2 == false)
            {

            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                tuş1 = true;
            }

            if (e.KeyCode == Keys.E)
            {
                tuş2 = true;
            }

            if (tuş1 == true && tuş2 == true)
            {

                kelime = "";
                 textBox2.Cut();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
            {
                tuş1 = false;
            }

            if (e.KeyCode == Keys.E)
            {
                tuş2 = false;
            }

            if (tuş1 == false && tuş2 == false)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
