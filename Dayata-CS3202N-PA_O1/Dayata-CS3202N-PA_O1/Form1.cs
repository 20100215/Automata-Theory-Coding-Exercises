/********************************************************
PROGRAM NAME - CS3202N_DAYATA_W_PA-O1_PO
AUTHOR       - Wayne Matthew A. Dayata 
DATE         - April 29, 2023
DESCRIPTION  - Reverses all letters of each word in a string.
********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dayata_CS3202N_PA_O1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string processText(string input)
        {
            string reversed = "";

            foreach (var word in input.Split(' '))
            {
                string temp = "";
                foreach (var ch in word.ToCharArray())
                {
                    temp = ch + temp;
                }
                reversed = reversed + temp + " ";
            }
            
            return reversed;
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            int length = input.TextLength;
            int spaceCount = input.Text.Count(s => s == ' ');
            if(length - spaceCount > 0)
            {
                enterBtn.Enabled = true;
            }
            else
            {
                enterBtn.Enabled = false;
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            input.Text = "";
            input.Enabled = true;
            output.Text = "";
            resetBtn.Enabled = false;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            input.Enabled = false;
            enterBtn.Enabled = false;
            resetBtn.Enabled = true;
            output.Text = processText(input.Text);
        }
    }
}
