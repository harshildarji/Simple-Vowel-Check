using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VowelCheck
{
    public partial class VowelCheck : Form
    {
        public VowelCheck()
        {
            InitializeComponent();
        }

        int a, ee, i, o, u, flag;
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text.ToLower();
            string s = null;
            a = ee = i = o = u = 0;
            if (str.Equals(""))
            {
                MessageBox.Show("You should enter some data to performe vowel check","Warning");
            }
            else
            {
                foreach (char c in str)
                {
                    if (c == 'a') 
                    { 
                        a++;
                        if (a == 1) 
                        {
                            if (flag == 0) { s = s + "a"; flag++; }
                            else { s = s + ", a"; }
                        }
                    }
                    else if (c == 'e') 
                    { 
                        ee++;
                        if (ee == 1) 
                        {
                            if (flag == 0) { s = s + "e"; flag++; }
                            else { s = s + ", e"; }
                        }
                    }
                    else if (c == 'i') 
                    { 
                        i++;
                        if (i == 1)
                        {
                            if (flag == 0) { s = s + "i"; flag++; }
                            else { s = s + ", i"; }
                        }
                    }
                    else if (c == 'o') 
                    { 
                        o++;
                        if (o == 1)
                        {
                            if (flag == 0) { s = s + "o"; flag++; }
                            else { s = s + ", o"; }
                        }
                    }
                    else if (c == 'u') 
                    { 
                        u++;
                        if (u == 1)
                        {
                            if (flag == 0) { s = s + "u"; flag++; }
                            else { s = s + ", u"; }
                        }
                    }
                }
                if (a == 0 || ee == 0 || i == 0 || o == 0 || u == 0) { MessageBox.Show("Available vowels: " + s + "", "Check Result"); }
                else { MessageBox.Show("All the vowels are available", "Check Result"); }
                button2.Enabled = true;
                flag = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a: " + a + ", e: " + ee + ", i: " + i + ", o: " + o + ", u: " + u + "", "Analysis");
            button2.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vowel Check (v1.0)\n\nby: Harshil Darji (github.com/H-Darji)", "About");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
