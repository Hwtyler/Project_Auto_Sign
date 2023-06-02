namespace Signage_Auto_Work
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button2 = new Button();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            pictureBox2 = new PictureBox();
            button3 = new Button();
            textBox2 = new TextBox();
            textBox5 = new TextBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            toolTip1 = new ToolTip(components);
            button8 = new Button();
            button7 = new Button();
            button10 = new Button();
            button11 = new Button();
            button9 = new Button();
            textBox1 = new TextBox();
            textBox7 = new TextBox();
            button12 = new Button();
            button13 = new Button();
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            richTextBox6 = new RichTextBox();
            richTextBox7 = new RichTextBox();
            richTextBox8 = new RichTextBox();
            richTextBox9 = new RichTextBox();
            richTextBox10 = new RichTextBox();
            richTextBox11 = new RichTextBox();
            richTextBox12 = new RichTextBox();
            richTextBox13 = new RichTextBox();
            richTextBox14 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(282, 652);
            button1.Name = "button1";
            button1.Size = new Size(140, 23);
            button1.TabIndex = 0;
            button1.Text = "Remove Cortana";
            toolTip1.SetToolTip(button1, "Removes Cortana from the OS");
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(280, 276);
            button2.Name = "button2";
            button2.Size = new Size(140, 23);
            button2.TabIndex = 2;
            button2.Text = "Disable Recovery";
            toolTip1.SetToolTip(button2, "Disables automatic repair.");
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth8Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.its;
            pictureBox2.Location = new Point(131, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(179, 168);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(12, 461);
            button3.Name = "button3";
            button3.Size = new Size(140, 23);
            button3.TabIndex = 5;
            button3.Text = "Create TEA Account";
            toolTip1.SetToolTip(button3, "MAKE SURE TO ENTER INFO BELOW FIRST!");
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 487);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Enter Asset Tag";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 516);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Enter TEA Password";
            textBox5.Size = new Size(140, 23);
            textBox5.TabIndex = 9;
            // 
            // button4
            // 
            button4.Location = new Point(280, 363);
            button4.Name = "button4";
            button4.Size = new Size(140, 23);
            button4.TabIndex = 10;
            button4.Text = "Custom Data";
            toolTip1.SetToolTip(button4, "Opens Custom Data Form");
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(280, 218);
            button5.Name = "button5";
            button5.Size = new Size(140, 23);
            button5.TabIndex = 11;
            button5.Text = "Join Domain";
            toolTip1.SetToolTip(button5, "Alternative way to join the Domain");
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(280, 304);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(140, 24);
            button6.TabIndex = 12;
            button6.Text = "Add Default Admins";
            toolTip1.SetToolTip(button6, "Adds DS-Administrators and ds_its_admins");
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button8
            // 
            button8.Location = new Point(280, 333);
            button8.Name = "button8";
            button8.Size = new Size(140, 23);
            button8.TabIndex = 14;
            button8.Text = "Disable Net Interfaces";
            toolTip1.SetToolTip(button8, "Disables unused network interfaces.");
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(282, 594);
            button7.Name = "button7";
            button7.Size = new Size(140, 23);
            button7.TabIndex = 15;
            button7.Text = "Adjust TaskBar";
            toolTip1.SetToolTip(button7, "Removes search and any pinned applications");
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button10
            // 
            button10.Location = new Point(280, 461);
            button10.Name = "button10";
            button10.Size = new Size(140, 23);
            button10.TabIndex = 19;
            button10.Text = "Add User to Admin";
            toolTip1.SetToolTip(button10, "MAKE SURE TO ENTER GROUP NAME BELOW");
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(282, 691);
            button11.Name = "button11";
            button11.Size = new Size(140, 23);
            button11.TabIndex = 20;
            button11.Text = "Set Auto-Login";
            toolTip1.SetToolTip(button11, "Tool does not currently work. Please use Auto_login batch script.");
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button9
            // 
            button9.Location = new Point(282, 623);
            button9.Name = "button9";
            button9.Size = new Size(140, 23);
            button9.TabIndex = 16;
            button9.Text = "Player to Startup";
            toolTip1.SetToolTip(button9, "Copies content player to startup for current user.");
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(280, 487);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Sign User";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 17;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(280, 517);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Enter Sign User Password";
            textBox7.Size = new Size(140, 23);
            textBox7.TabIndex = 21;
            // 
            // button12
            // 
            button12.Image = Properties.Resources.Information_icon_svg;
            button12.Location = new Point(9, 691);
            button12.Name = "button12";
            button12.Size = new Size(59, 23);
            button12.TabIndex = 22;
            button12.Text = "About";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button13
            // 
            button13.Location = new Point(280, 247);
            button13.Name = "button13";
            button13.Size = new Size(140, 23);
            button13.TabIndex = 23;
            button13.Text = "Open WebDHCP";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.ScrollBar;
            richTextBox1.Location = new Point(11, 218);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(248, 23);
            richTextBox1.TabIndex = 24;
            richTextBox1.Text = "1. Join computer to domain";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.ScrollBar;
            richTextBox2.Location = new Point(11, 248);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.ReadOnly = true;
            richTextBox2.Size = new Size(248, 23);
            richTextBox2.TabIndex = 25;
            richTextBox2.Text = "2. Add computer into WebDCHP";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.ScrollBar;
            richTextBox3.Location = new Point(11, 277);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.ReadOnly = true;
            richTextBox3.Size = new Size(248, 23);
            richTextBox3.TabIndex = 26;
            richTextBox3.Text = "3. Disable Automatic recovery.";
            // 
            // richTextBox4
            // 
            richTextBox4.BackColor = SystemColors.ScrollBar;
            richTextBox4.Location = new Point(11, 365);
            richTextBox4.Name = "richTextBox4";
            richTextBox4.ReadOnly = true;
            richTextBox4.Size = new Size(248, 23);
            richTextBox4.TabIndex = 29;
            richTextBox4.Text = "6. Fill out Custom Data form";
            // 
            // richTextBox5
            // 
            richTextBox5.BackColor = SystemColors.ScrollBar;
            richTextBox5.Location = new Point(11, 336);
            richTextBox5.Name = "richTextBox5";
            richTextBox5.ReadOnly = true;
            richTextBox5.Size = new Size(248, 23);
            richTextBox5.TabIndex = 28;
            richTextBox5.Text = "5. Disable unused Network Interfaces";
            // 
            // richTextBox6
            // 
            richTextBox6.BackColor = SystemColors.ScrollBar;
            richTextBox6.Location = new Point(11, 306);
            richTextBox6.Name = "richTextBox6";
            richTextBox6.ReadOnly = true;
            richTextBox6.Size = new Size(248, 23);
            richTextBox6.TabIndex = 27;
            richTextBox6.Text = "4. Add the default admins";
            // 
            // richTextBox7
            // 
            richTextBox7.BackColor = SystemColors.ScrollBar;
            richTextBox7.Location = new Point(13, 624);
            richTextBox7.Name = "richTextBox7";
            richTextBox7.ReadOnly = true;
            richTextBox7.Size = new Size(248, 23);
            richTextBox7.TabIndex = 32;
            richTextBox7.Text = "11. Copy content player to startup";
            // 
            // richTextBox8
            // 
            richTextBox8.BackColor = SystemColors.ScrollBar;
            richTextBox8.Location = new Point(13, 653);
            richTextBox8.Name = "richTextBox8";
            richTextBox8.ReadOnly = true;
            richTextBox8.Size = new Size(248, 23);
            richTextBox8.TabIndex = 31;
            richTextBox8.Text = "12. Remove Cortana from account";
            // 
            // richTextBox9
            // 
            richTextBox9.BackColor = SystemColors.ScrollBar;
            richTextBox9.Location = new Point(13, 594);
            richTextBox9.Name = "richTextBox9";
            richTextBox9.ReadOnly = true;
            richTextBox9.Size = new Size(248, 23);
            richTextBox9.TabIndex = 30;
            richTextBox9.Text = "10. Remove the search and pinned apps.";
            // 
            // richTextBox10
            // 
            richTextBox10.BackColor = SystemColors.ScrollBar;
            richTextBox10.Location = new Point(12, 417);
            richTextBox10.Name = "richTextBox10";
            richTextBox10.ReadOnly = true;
            richTextBox10.Size = new Size(140, 38);
            richTextBox10.TabIndex = 33;
            richTextBox10.Text = "7. TEA Account Creation";
            // 
            // richTextBox11
            // 
            richTextBox11.BackColor = SystemColors.ScrollBar;
            richTextBox11.Location = new Point(280, 417);
            richTextBox11.Name = "richTextBox11";
            richTextBox11.ReadOnly = true;
            richTextBox11.Size = new Size(140, 38);
            richTextBox11.TabIndex = 34;
            richTextBox11.Text = "8. Add Sign User to Admin Group";
            // 
            // richTextBox12
            // 
            richTextBox12.BackColor = Color.WhiteSmoke;
            richTextBox12.BorderStyle = BorderStyle.None;
            richTextBox12.ForeColor = SystemColors.WindowFrame;
            richTextBox12.Location = new Point(9, 186);
            richTextBox12.Name = "richTextBox12";
            richTextBox12.ReadOnly = true;
            richTextBox12.Size = new Size(110, 23);
            richTextBox12.TabIndex = 35;
            richTextBox12.Text = "Instructions";
            // 
            // richTextBox13
            // 
            richTextBox13.BackColor = Color.WhiteSmoke;
            richTextBox13.BorderStyle = BorderStyle.None;
            richTextBox13.ForeColor = SystemColors.WindowFrame;
            richTextBox13.Location = new Point(310, 186);
            richTextBox13.Name = "richTextBox13";
            richTextBox13.ReadOnly = true;
            richTextBox13.RightToLeft = RightToLeft.Yes;
            richTextBox13.Size = new Size(110, 23);
            richTextBox13.TabIndex = 36;
            richTextBox13.Text = "Buttons";
            // 
            // richTextBox14
            // 
            richTextBox14.BackColor = Color.WhiteSmoke;
            richTextBox14.BorderStyle = BorderStyle.None;
            richTextBox14.ForeColor = SystemColors.WindowFrame;
            richTextBox14.Location = new Point(28, 556);
            richTextBox14.Name = "richTextBox14";
            richTextBox14.ReadOnly = true;
            richTextBox14.RightToLeft = RightToLeft.No;
            richTextBox14.Size = new Size(377, 23);
            richTextBox14.TabIndex = 37;
            richTextBox14.Text = "9. Use the AutoLogin script from the application directory and reboot.";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 726);
            Controls.Add(richTextBox14);
            Controls.Add(richTextBox13);
            Controls.Add(richTextBox12);
            Controls.Add(richTextBox11);
            Controls.Add(richTextBox10);
            Controls.Add(richTextBox7);
            Controls.Add(richTextBox8);
            Controls.Add(richTextBox9);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox6);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Controls.Add(button13);
            Controls.Add(button12);
            Controls.Add(textBox7);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(textBox1);
            Controls.Add(button9);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(textBox5);
            Controls.Add(textBox2);
            Controls.Add(button3);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Signage Ver. 1.1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button2;
        private ImageList imageList1;
        private ImageList imageList2;
        private PictureBox pictureBox2;
        private Button button3;
        private TextBox textBox2;
        private TextBox textBox5;
        private Button button4;
        private Button button5;
        private Button button6;
        private ToolTip toolTip1;
        private Button button8;
        private Button button7;
        private Button button9;
        private TextBox textBox1;
        private Button button10;
        private Button button11;
        private TextBox textBox7;
        private Button button12;
        private Button button13;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private RichTextBox richTextBox6;
        private RichTextBox richTextBox7;
        private RichTextBox richTextBox8;
        private RichTextBox richTextBox9;
        private RichTextBox richTextBox10;
        private RichTextBox richTextBox11;
        private RichTextBox richTextBox12;
        private RichTextBox richTextBox13;
        private RichTextBox richTextBox14;
    }
}