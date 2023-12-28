namespace Dayata_CS3202N_PA_O1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.output = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(178, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CS 3202N - PROGRAM OUTPUT #2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(439, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "By Wayne Matthew Dayata | 4/29/2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(47, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(47, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 37);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(95, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(657, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "This program checks and accepts string containing even a’s and odd b’s.";
            // 
            // input
            // 
            this.input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input.Location = new System.Drawing.Point(196, 162);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(600, 34);
            this.input.TabIndex = 5;
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.ForeColor = System.Drawing.Color.Firebrick;
            this.output.Location = new System.Drawing.Point(196, 232);
            this.output.MinimumSize = new System.Drawing.Size(600, 30);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(600, 30);
            this.output.TabIndex = 6;
            this.output.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // enterBtn
            // 
            this.enterBtn.Enabled = false;
            this.enterBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterBtn.Location = new System.Drawing.Point(273, 294);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(156, 46);
            this.enterBtn.TabIndex = 7;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Enabled = false;
            this.resetBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(455, 294);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(156, 46);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label6.Location = new System.Drawing.Point(51, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(568, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Note: Accepted inputs in the textbox are only lowercase characters a and b.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(845, 413);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CS3202N_DAYATA_W_PA-O2_PO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Label label6;
    }
}

