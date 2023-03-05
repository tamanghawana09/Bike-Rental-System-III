namespace bikeRental
{
    partial class Option
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
            gradientPanel1 = new gradientPanel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            gradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 45F;
            gradientPanel1.BackColor = Color.Cyan;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(label2);
            gradientPanel1.Controls.Add(iconButton1);
            gradientPanel1.Controls.Add(button2);
            gradientPanel1.Controls.Add(button1);
            gradientPanel1.Controls.Add(panel3);
            gradientPanel1.Controls.Add(panel2);
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Controls.Add(label1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(300, 400);
            gradientPanel1.TabIndex = 1;
            gradientPanel1.TopColor = Color.MediumBlue;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Transparent;
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton1.IconColor = Color.Red;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.IconSize = 20;
            iconButton1.Location = new Point(271, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(26, 19);
            iconButton1.TabIndex = 11;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Aqua;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(0, 101, 225);
            button2.Location = new Point(26, 228);
            button2.Name = "button2";
            button2.Size = new Size(250, 36);
            button2.TabIndex = 9;
            button2.Text = "Per Day";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Aqua;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 101, 225);
            button1.Location = new Point(26, 167);
            button1.Name = "button1";
            button1.Size = new Size(250, 36);
            button1.TabIndex = 9;
            button1.Text = "Per Hour";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(26, 270);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 1);
            panel2.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(1, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 1);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(4, 27);
            label1.Name = "label1";
            label1.Size = new Size(296, 45);
            label1.TabIndex = 5;
            label1.Text = "Bike Rental System";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Location = new Point(26, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 1);
            panel3.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(35, 115);
            label2.Name = "label2";
            label2.Size = new Size(228, 21);
            label2.TabIndex = 12;
            label2.Text = "( choose your renting option )";
            // 
            // Option
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 400);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Option";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Option";
            gradientPanel1.ResumeLayout(false);
            gradientPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private gradientPanel gradientPanel1;
        private Panel panel2;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Panel panel3;
    }
}