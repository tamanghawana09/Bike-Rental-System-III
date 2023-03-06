namespace bikeRental.User_Control_for_payment
{
    partial class cashPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.LimeGreen;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Yu Gothic UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 15;
            iconButton1.Location = new Point(159, 261);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(84, 32);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Proceed";
            iconButton1.TextImageRelation = TextImageRelation.TextBeforeImage;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(21, 33);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(79, 25);
            label3.TabIndex = 0;
            label3.Text = "Name : ";
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 10;
            bunifuElipse1.TargetControl = this;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(240, 241, 243);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(92, 34);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(21, 70);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(183, 25);
            label1.TabIndex = 0;
            label1.Text = "Hours to be rented :";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(240, 241, 243);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(210, 70);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Cyan;
            panel1.ForeColor = Color.Transparent;
            panel1.Location = new Point(21, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 2);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Cyan;
            panel2.ForeColor = Color.Transparent;
            panel2.Location = new Point(21, 155);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 2);
            panel2.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(21, 122);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(138, 25);
            label2.TabIndex = 0;
            label2.Text = "Total Amount :";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(240, 241, 243);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(159, 126);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(223, 23);
            textBox3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(21, 170);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(171, 25);
            label4.TabIndex = 0;
            label4.Text = "Advance Amount :";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(240, 241, 243);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Yu Gothic UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(194, 172);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(188, 23);
            textBox4.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Yu Gothic UI Semilight", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(107, 214);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(182, 15);
            label5.TabIndex = 0;
            label5.Text = "( Deposit amount must be ready )";
            // 
            // cashPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(iconButton1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label3);
            Name = "cashPayment";
            Size = new Size(405, 317);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
    }
}
