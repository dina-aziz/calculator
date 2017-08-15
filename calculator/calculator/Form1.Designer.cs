namespace calculator
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
            this.out_screen = new System.Windows.Forms.TextBox();
            this.button_leftbr = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_mult = new System.Windows.Forms.Button();
            this.button_div = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button_rightbr = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_clr = new System.Windows.Forms.Button();
            this.button_bkspace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // out_screen
            // 
            this.out_screen.Location = new System.Drawing.Point(12, 27);
            this.out_screen.Name = "out_screen";
            this.out_screen.Size = new System.Drawing.Size(260, 20);
            this.out_screen.TabIndex = 0;
            this.out_screen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.out_screen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_leftbr
            // 
            this.button_leftbr.Location = new System.Drawing.Point(14, 207);
            this.button_leftbr.Name = "button_leftbr";
            this.button_leftbr.Size = new System.Drawing.Size(41, 42);
            this.button_leftbr.TabIndex = 10;
            this.button_leftbr.Text = "(";
            this.button_leftbr.UseVisualStyleBackColor = true;
            this.button_leftbr.Click += new System.EventHandler(this.button_leftbr_Click);
            // 
            // button_plus
            // 
            this.button_plus.Location = new System.Drawing.Point(174, 106);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(48, 43);
            this.button_plus.TabIndex = 13;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_minus
            // 
            this.button_minus.Location = new System.Drawing.Point(224, 106);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(48, 43);
            this.button_minus.TabIndex = 14;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_mult
            // 
            this.button_mult.Location = new System.Drawing.Point(174, 155);
            this.button_mult.Name = "button_mult";
            this.button_mult.Size = new System.Drawing.Size(48, 43);
            this.button_mult.TabIndex = 15;
            this.button_mult.Text = "*";
            this.button_mult.UseVisualStyleBackColor = true;
            this.button_mult.Click += new System.EventHandler(this.button_mult_Click);
            // 
            // button_div
            // 
            this.button_div.Location = new System.Drawing.Point(224, 155);
            this.button_div.Name = "button_div";
            this.button_div.Size = new System.Drawing.Size(48, 43);
            this.button_div.TabIndex = 16;
            this.button_div.Text = "/";
            this.button_div.UseVisualStyleBackColor = true;
            this.button_div.Click += new System.EventHandler(this.button_div_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 43);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 43);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(109, 63);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(45, 43);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 40);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(61, 112);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(42, 40);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(109, 112);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 40);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(14, 158);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 44);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(42, 44);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(109, 158);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(45, 44);
            this.button9.TabIndex = 9;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(61, 207);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(42, 42);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button_rightbr
            // 
            this.button_rightbr.Location = new System.Drawing.Point(109, 207);
            this.button_rightbr.Name = "button_rightbr";
            this.button_rightbr.Size = new System.Drawing.Size(45, 42);
            this.button_rightbr.TabIndex = 12;
            this.button_rightbr.Text = ")";
            this.button_rightbr.UseVisualStyleBackColor = true;
            this.button_rightbr.Click += new System.EventHandler(this.button_rightbr_Click);
            // 
            // button_equal
            // 
            this.button_equal.Location = new System.Drawing.Point(224, 206);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(48, 43);
            this.button_equal.TabIndex = 17;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // button_dot
            // 
            this.button_dot.Location = new System.Drawing.Point(174, 206);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(48, 43);
            this.button_dot.TabIndex = 18;
            this.button_dot.Text = ".";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_clr
            // 
            this.button_clr.Location = new System.Drawing.Point(224, 57);
            this.button_clr.Name = "button_clr";
            this.button_clr.Size = new System.Drawing.Size(48, 43);
            this.button_clr.TabIndex = 19;
            this.button_clr.Text = "C";
            this.button_clr.UseVisualStyleBackColor = true;
            this.button_clr.Click += new System.EventHandler(this.button10_Click);
            // 
            // button_bkspace
            // 
            this.button_bkspace.Location = new System.Drawing.Point(174, 57);
            this.button_bkspace.Name = "button_bkspace";
            this.button_bkspace.Size = new System.Drawing.Size(44, 43);
            this.button_bkspace.TabIndex = 20;
            this.button_bkspace.Text = "<-";
            this.button_bkspace.UseVisualStyleBackColor = true;
            this.button_bkspace.Click += new System.EventHandler(this.button_bkspace_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_bkspace);
            this.Controls.Add(this.button_clr);
            this.Controls.Add(this.button_dot);
            this.Controls.Add(this.button_equal);
            this.Controls.Add(this.button_div);
            this.Controls.Add(this.button_mult);
            this.Controls.Add(this.button_minus);
            this.Controls.Add(this.button_plus);
            this.Controls.Add(this.button_rightbr);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button_leftbr);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.out_screen);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox out_screen;
        private System.Windows.Forms.Button button_leftbr;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_mult;
        private System.Windows.Forms.Button button_div;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button_rightbr;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_clr;
        private System.Windows.Forms.Button button_bkspace;
    }
}

