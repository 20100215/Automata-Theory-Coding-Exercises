/********************************************************
PROGRAM NAME - CS3202N_DAYATA_W_PA-O3_PO
AUTHOR       - Wayne Matthew A. Dayata 
DATE         - April 29, 2023
DESCRIPTION  - Accepts the language L = { a^n b^n c^n / n ≥ 0 }
                from an argument string w Є { a,b,c }.
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
            int state = 1;
            char[] arr = input.ToCharArray();

            for(int x=0; x<arr.Length && state != 0; x++)
            {
                switch(state)
                {
                    case 1:
                        switch(arr[x]) {
                            case 'a': state = 1; break;
                            case 'b': state = 2; break;
                            case 'c': state = 3; break;
                        }
                        break;

                    case 2:
                        switch (arr[x])
                        {
                            case 'a': state = 0; break;
                            case 'b': state = 2; break;
                            case 'c': state = 3; break;
                        }
                        break;

                    case 3:
                        switch (arr[x])
                        {
                            case 'a': state = 0; break;
                            case 'b': state = 0; break;
                            case 'c': state = 3; break;
                        }
                        break;

                    default:
                        break;
                }
            }

            if(state != 0) 
            {
                return "Y";
            }
            else
            {
                return "N";
            }
            
        }

        private void input_TextChanged(object sender, EventArgs e)
        {
            enterBtn.Enabled = true;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            input.Text = "";
            input.Enabled = true;
            output.Text = "";
            resetBtn.Enabled = false;
            enterBtn.Enabled = true;
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
            //restrict input to only 'a', 'b', and 'c'
            if (e.KeyChar == 'a' || 
                e.KeyChar == 'b' ||
                e.KeyChar == 'c' ||
                "\b".Contains(e.KeyChar))
                return;

            e.Handled = true;
        }

        
    }
}
