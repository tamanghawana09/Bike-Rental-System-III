namespace bikeRental.User_Controls
{
    partial class profileUC
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
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            gradientPanel3 = new gradientPanel();
            image1 = new PictureBox();
            button1 = new Button();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            gradientPanel2 = new gradientPanel();
            label11 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)image1).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 57);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(330, 9);
            label1.Name = "label1";
            label1.Size = new Size(267, 40);
            label1.TabIndex = 0;
            label1.Text = "Bike Rental System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(12, 60);
            label2.Name = "label2";
            label2.Size = new Size(116, 45);
            label2.TabIndex = 10;
            label2.Text = "Profile";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BackColor = Color.White;
            gradientPanel3.BackgroundImageLayout = ImageLayout.None;
            gradientPanel3.BottomColor = Color.Empty;
            gradientPanel3.Location = new Point(21, 108);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(888, 10);
            gradientPanel3.TabIndex = 11;
            gradientPanel3.TopColor = Color.Cyan;
            // 
            // image1
            // 
            image1.BorderStyle = BorderStyle.FixedSingle;
            image1.Location = new Point(21, 124);
            image1.Name = "image1";
            image1.Size = new Size(165, 163);
            image1.SizeMode = PictureBoxSizeMode.Zoom;
            image1.TabIndex = 12;
            image1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(0, 192, 192);
            button1.Location = new Point(21, 293);
            button1.Name = "button1";
            button1.Size = new Size(165, 32);
            button1.TabIndex = 13;
            button1.Text = "Upload";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 15;
            bunifuElipse1.TargetControl = button1;
            // 
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.BottomColor = Color.White;
            gradientPanel2.Controls.Add(label11);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(0, 541);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(933, 39);
            gradientPanel2.TabIndex = 14;
            gradientPanel2.TopColor = Color.White;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkTurquoise;
            label11.Location = new Point(590, 10);
            label11.Name = "label11";
            label11.Size = new Size(262, 20);
            label11.TabIndex = 0;
            label11.Text = "All Rights Reserved. Bike Rental System";
            // 
            // profileUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            BackgroundImageLayout = ImageLayout.None;
            Controls.Add(gradientPanel2);
            Controls.Add(button1);
            Controls.Add(image1);
            Controls.Add(gradientPanel3);
            Controls.Add(label2);
            Controls.Add(panel2);
            Name = "profileUC";
            Size = new Size(933, 580);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)image1).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Label label2;
        private gradientPanel gradientPanel3;
        private PictureBox image1;
        private Button button1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private gradientPanel gradientPanel2;
        private Label label11;
    }
}
