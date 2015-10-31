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

        int a, ee, i, o, u;
        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            a = ee = i = o = u = 0;
            if (str.Equals(""))
            {
                MessageBox.Show("You should enter some data to performe vowel check","Warning");
            }
            else
            {
                foreach (char c in str)
                {
                    if (c == 'a') { a++; }
                    else if (c == 'e') { ee++; }
                    else if (c == 'i') { i++; }
                    else if (c == 'o') { o++; }
                    else if (c == 'u') { u++; }
                }
                if (a == 0 || ee == 0 || i == 0 || o == 0 || u == 0) { MessageBox.Show("Not all the vowels are available", "Check Result"); }
                else { MessageBox.Show("All the vowels are available", "Check Result"); }
                button2.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("a: " + a + ", e: " + ee + ", i: " + i + ", o: " + o + ", u: " + u + "", "Analysis");
            button2.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vowel Check (v1.0)\n\nby: Harshil Darji (github.com\\H-Darji)", "About");
        }
    }
}
