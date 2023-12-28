/********************************************************
PROGRAM NAME - CS3202N_DAYATA_W_PA-O4_PO
AUTHOR       - Wayne Matthew A. Dayata 
DATE         - April 29, 2023
DESCRIPTION  - computes the conversion of an octal string 
                into a binary string such that the numeric 
                value remains the same. 
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
            string binary = "";
            bool nonzeroProcessed = false;

            //binary equivalent
            string[] binaryWithoutLeadingZeros =
                {"","1","10","11","100","101","110","111"};
            string[] binaryWithLeadingZeros =
                {"000","001","010","011","100","101","110","111"};

            char[] digits = input.ToCharArray();
            for (int x=0; x<digits.Length; x++)
            {
                switch (nonzeroProcessed)
                {
                    case true:
                        binary += binaryWithLeadingZeros[digits[x] - '0'];
                        break;
                    case false:
                        binary += binaryWithoutLeadingZeros[digits[x] - '0'];
                        break;
                }
                if (nonzeroProcessed == false && digits[x] != '0')
                {
                    nonzeroProcessed = true;
                }
            }

            if(binary == "")
            {
                binary = "0";
            }

            return binary;
            
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
            //restrict input to only numbers '0' to '7'
            if ((e.KeyChar >= '0' && e.KeyChar <= '7' ) || "\b".Contains(e.KeyChar))
                return;

            e.Handled = true;
        }

    }
}
