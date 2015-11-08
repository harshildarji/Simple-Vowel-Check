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
                        if (a == 1) { s = s + "a"; }
                    }
                    else if (c == 'e') 
                    { 
                        ee++;
                        if (ee == 1) { s = s + "e"; }
                    }
                    else if (c == 'i') 
                    { 
                        i++;
                        if (i == 1) { s = s + "i"; }
                    }
                    else if (c == 'o') 
                    { 
                        o++;
                        if (o == 1) { s = s + "o"; }
                    }
                    else if (c == 'u') 
                    { 
                        u++;
                        if (u == 1) { s = s + "u"; }
                    }
                }
                if (a == 0 && ee == 0 && i == 0 && o == 0 && u == 0) 
                { 
                    MessageBox.Show("No vowels are there", "Check Result");
                    button2.Enabled = false;
                }
                else if (a == 0 || ee == 0 || i == 0 || o == 0 || u == 0) 
                {
                    char[] s1 = s.ToCharArray();
                    Array.Sort(s1);
                    string s2 = new String(s1);
                    s = null;
                    foreach(char c in s2)
                    {
                        if (s == null)
                        {
                            s = s + c;
                        }
                        else
                        {
                            s = s + ", " + c;
                        }
                    }
                    MessageBox.Show("Available vowels: " + s + "", "Check Result");
                    button2.Enabled = true;
                }
                else 
                { 
                    MessageBox.Show("All the vowels are available", "Check Result");
                    button2.Enabled = true;
                }
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
            MessageBox.Show("Vowel Check (v 1.3)\n\nby: Harshil Darji (github.com/H-Darji)", "About");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }
    }
}
