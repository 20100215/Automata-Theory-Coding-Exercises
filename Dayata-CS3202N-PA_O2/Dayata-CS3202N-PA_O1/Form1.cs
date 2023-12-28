/********************************************************
PROGRAM NAME - CS3202N_DAYATA_W_PA-O2_PO
AUTHOR       - Wayne Matthew A. Dayata 
DATE         - April 29, 2023
DESCRIPTION  - Accepts string containing even a's and odd b's. 
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
            int Acount = 0, Bcount = 0;

            foreach (var ch in input.ToCharArray())
            {
                if (ch == 'a') Acount++;
                if (ch == 'b') Bcount++;
            }

            if(Acount % 2 == 0 && Bcount % 2 != 0) 
            {
                return "YES";
            }
            else
            {
                return "NO";
            }
            
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

        private void input_KeyPress(object sender, KeyPressEventArgs e)
        {
            //restrict input to only 'a' and 'b'
            // allow lowercase characters
            if (e.KeyChar == 'a' || e.KeyChar == 'b' || "\b".Contains(e.KeyChar))
                return;

            e.Handled = true;
        }

    }
}
