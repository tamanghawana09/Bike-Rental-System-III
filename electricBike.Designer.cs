namespace bikeRental
{
    partial class electricBike
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
            components = new System.ComponentModel.Container();
            gradientPanel1 = new gradientPanel();
            pictureBox1 = new PictureBox();
            logoutBtn = new FontAwesome.Sharp.IconButton();
            helpBtn = new FontAwesome.Sharp.IconButton();
            motorcyceBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            userButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(components);
            panelContainer = new Panel();
            gradientPanel3 = new gradientPanel();
            label1 = new Label();
            gradientPanel4 = new gradientPanel();
            bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            panel2 = new Panel();
            label2 = new Label();
            bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            label3 = new Label();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelContainer.SuspendLayout();
            gradientPanel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 40F;
            gradientPanel1.BackColor = Color.FromArgb(128, 255, 255);
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(logoutBtn);
            gradientPanel1.Controls.Add(helpBtn);
            gradientPanel1.Controls.Add(motorcyceBtn);
            gradientPanel1.Controls.Add(homeBtn);
            gradientPanel1.Controls.Add(userButton);
            gradientPanel1.Controls.Add(panel1);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(67, 580);
            gradientPanel1.TabIndex = 22;
            gradientPanel1.TopColor = Color.MediumBlue;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 69);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.Transparent;
            logoutBtn.FlatAppearance.BorderSize = 0;
            logoutBtn.FlatStyle = FlatStyle.Flat;
            logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            logoutBtn.IconColor = Color.White;
            logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            logoutBtn.IconSize = 27;
            logoutBtn.Location = new Point(3, 530);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Padding = new Padding(10);
            logoutBtn.Size = new Size(60, 45);
            logoutBtn.TabIndex = 2;
            logoutBtn.UseVisualStyleBackColor = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // helpBtn
            // 
            helpBtn.BackColor = Color.Transparent;
            helpBtn.FlatAppearance.BorderSize = 0;
            helpBtn.FlatStyle = FlatStyle.Flat;
            helpBtn.IconChar = FontAwesome.Sharp.IconChar.Question;
            helpBtn.IconColor = Color.Navy;
            helpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            helpBtn.IconSize = 27;
            helpBtn.Location = new Point(3, 333);
            helpBtn.Name = "helpBtn";
            helpBtn.Padding = new Padding(10);
            helpBtn.Size = new Size(60, 45);
            helpBtn.TabIndex = 2;
            helpBtn.UseVisualStyleBackColor = false;
            helpBtn.Click += helpBtn_Click;
            helpBtn.Enter += helpBtn_Enter;
            helpBtn.Leave += helpBtn_Leave;
            // 
            // motorcyceBtn
            // 
            motorcyceBtn.BackColor = Color.Transparent;
            motorcyceBtn.FlatAppearance.BorderSize = 0;
            motorcyceBtn.FlatStyle = FlatStyle.Flat;
            motorcyceBtn.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            motorcyceBtn.IconColor = Color.Navy;
            motorcyceBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            motorcyceBtn.IconSize = 27;
            motorcyceBtn.Location = new Point(3, 282);
            motorcyceBtn.Name = "motorcyceBtn";
            motorcyceBtn.Padding = new Padding(10);
            motorcyceBtn.Size = new Size(60, 45);
            motorcyceBtn.TabIndex = 2;
            motorcyceBtn.UseVisualStyleBackColor = false;
            motorcyceBtn.Click += motorcyceBtn_Click;
            motorcyceBtn.Enter += motorcyceBtn_Enter;
            motorcyceBtn.Leave += motorcyceBtn_Leave;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.Transparent;
            homeBtn.FlatAppearance.BorderSize = 0;
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.IconChar = FontAwesome.Sharp.IconChar.Home;
            homeBtn.IconColor = Color.Navy;
            homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            homeBtn.IconSize = 27;
            homeBtn.Location = new Point(3, 233);
            homeBtn.Name = "homeBtn";
            homeBtn.Padding = new Padding(10);
            homeBtn.Size = new Size(60, 45);
            homeBtn.TabIndex = 2;
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            homeBtn.Enter += homeBtn_Enter;
            homeBtn.Leave += homeBtn_Leave;
            // 
            // userButton
            // 
            userButton.BackColor = Color.Transparent;
            userButton.FlatAppearance.BorderSize = 0;
            userButton.FlatStyle = FlatStyle.Flat;
            userButton.IconChar = FontAwesome.Sharp.IconChar.User;
            userButton.IconColor = Color.Navy;
            userButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            userButton.IconSize = 27;
            userButton.Location = new Point(3, 182);
            userButton.Name = "userButton";
            userButton.Padding = new Padding(20);
            userButton.Size = new Size(60, 45);
            userButton.TabIndex = 2;
            userButton.UseVisualStyleBackColor = false;
            userButton.Click += userButton_Click;
            userButton.Enter += userButton_Enter;
            userButton.Leave += userButton_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(245, 246, 248);
            panel1.Location = new Point(68, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(861, 575);
            panel1.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 42;
            bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 20;
            bunifuElipse2.TargetControl = helpBtn;
            // 
            // bunifuElipse3
            // 
            bunifuElipse3.ElipseRadius = 20;
            bunifuElipse3.TargetControl = homeBtn;
            // 
            // bunifuElipse4
            // 
            bunifuElipse4.ElipseRadius = 20;
            bunifuElipse4.TargetControl = logoutBtn;
            // 
            // bunifuElipse5
            // 
            bunifuElipse5.ElipseRadius = 20;
            bunifuElipse5.TargetControl = motorcyceBtn;
            // 
            // bunifuElipse6
            // 
            bunifuElipse6.ElipseRadius = 20;
            bunifuElipse6.TargetControl = userButton;
            // 
            // panelContainer
            // 
            panelContainer.Controls.Add(gradientPanel3);
            panelContainer.Controls.Add(gradientPanel4);
            panelContainer.Controls.Add(bunifuTileButton5);
            panelContainer.Controls.Add(bunifuTileButton4);
            panelContainer.Controls.Add(bunifuTileButton3);
            panelContainer.Controls.Add(bunifuTileButton2);
            panelContainer.Controls.Add(panel2);
            panelContainer.Controls.Add(bunifuTileButton1);
            panelContainer.Controls.Add(label3);
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(67, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(933, 580);
            panelContainer.TabIndex = 51;
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BottomColor = Color.White;
            gradientPanel3.Controls.Add(label1);
            gradientPanel3.Dock = DockStyle.Bottom;
            gradientPanel3.Location = new Point(0, 541);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(933, 39);
            gradientPanel3.TabIndex = 51;
            gradientPanel3.TopColor = Color.White;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Yu Gothic UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkTurquoise;
            label1.Location = new Point(618, 10);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 0;
            label1.Text = "All Rights Reserved. Bike Rental System";
            // 
            // gradientPanel4
            // 
            gradientPanel4.Angle = 0F;
            gradientPanel4.BackColor = Color.White;
            gradientPanel4.BackgroundImageLayout = ImageLayout.None;
            gradientPanel4.BottomColor = Color.Empty;
            gradientPanel4.Location = new Point(15, 102);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(200, 10);
            gradientPanel4.TabIndex = 50;
            gradientPanel4.TopColor = Color.Cyan;
            // 
            // bunifuTileButton5
            // 
            bunifuTileButton5.BackColor = Color.White;
            bunifuTileButton5.color = Color.White;
            bunifuTileButton5.colorActive = Color.MediumTurquoise;
            bunifuTileButton5.Cursor = Cursors.Hand;
            bunifuTileButton5.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton5.ForeColor = SystemColors.MenuHighlight;
            bunifuTileButton5.Image = Properties.Resources.Bella;
            bunifuTileButton5.ImagePosition = 0;
            bunifuTileButton5.ImageZoom = 85;
            bunifuTileButton5.LabelPosition = 51;
            bunifuTileButton5.LabelText = "Bella";
            bunifuTileButton5.Location = new Point(560, 182);
            bunifuTileButton5.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton5.Name = "bunifuTileButton5";
            bunifuTileButton5.Size = new Size(159, 194);
            bunifuTileButton5.TabIndex = 38;
            bunifuTileButton5.Click += bunifuTileButton5_Click;
            // 
            // bunifuTileButton4
            // 
            bunifuTileButton4.BackColor = Color.White;
            bunifuTileButton4.color = Color.White;
            bunifuTileButton4.colorActive = Color.MediumTurquoise;
            bunifuTileButton4.Cursor = Cursors.Hand;
            bunifuTileButton4.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton4.ForeColor = SystemColors.MenuHighlight;
            bunifuTileButton4.Image = Properties.Resources.niu;
            bunifuTileButton4.ImagePosition = 0;
            bunifuTileButton4.ImageZoom = 100;
            bunifuTileButton4.LabelPosition = 51;
            bunifuTileButton4.LabelText = "NIU";
            bunifuTileButton4.Location = new Point(389, 184);
            bunifuTileButton4.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton4.Name = "bunifuTileButton4";
            bunifuTileButton4.Size = new Size(159, 194);
            bunifuTileButton4.TabIndex = 39;
            bunifuTileButton4.Click += bunifuTileButton4_Click;
            // 
            // bunifuTileButton3
            // 
            bunifuTileButton3.BackColor = Color.White;
            bunifuTileButton3.color = Color.White;
            bunifuTileButton3.colorActive = Color.MediumTurquoise;
            bunifuTileButton3.Cursor = Cursors.Hand;
            bunifuTileButton3.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton3.ForeColor = SystemColors.MenuHighlight;
            bunifuTileButton3.Image = Properties.Resources.Super_Soco;
            bunifuTileButton3.ImagePosition = 0;
            bunifuTileButton3.ImageZoom = 95;
            bunifuTileButton3.LabelPosition = 51;
            bunifuTileButton3.LabelText = "Super Soco";
            bunifuTileButton3.Location = new Point(218, 184);
            bunifuTileButton3.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton3.Name = "bunifuTileButton3";
            bunifuTileButton3.Size = new Size(159, 194);
            bunifuTileButton3.TabIndex = 40;
            bunifuTileButton3.Click += bunifuTileButton3_Click;
            // 
            // bunifuTileButton2
            // 
            bunifuTileButton2.BackColor = Color.White;
            bunifuTileButton2.color = Color.White;
            bunifuTileButton2.colorActive = Color.MediumTurquoise;
            bunifuTileButton2.Cursor = Cursors.Hand;
            bunifuTileButton2.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton2.ForeColor = SystemColors.MenuHighlight;
            bunifuTileButton2.Image = Properties.Resources.Yadea;
            bunifuTileButton2.ImagePosition = 0;
            bunifuTileButton2.ImageZoom = 85;
            bunifuTileButton2.LabelPosition = 51;
            bunifuTileButton2.LabelText = "Yadea G5";
            bunifuTileButton2.Location = new Point(731, 182);
            bunifuTileButton2.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton2.Name = "bunifuTileButton2";
            bunifuTileButton2.Size = new Size(159, 194);
            bunifuTileButton2.TabIndex = 41;
            bunifuTileButton2.Click += bunifuTileButton2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(933, 57);
            panel2.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(272, 9);
            label2.Name = "label2";
            label2.Size = new Size(267, 40);
            label2.TabIndex = 0;
            label2.Text = "Bike Rental System";
            // 
            // bunifuTileButton1
            // 
            bunifuTileButton1.BackColor = Color.White;
            bunifuTileButton1.color = Color.White;
            bunifuTileButton1.colorActive = Color.MediumTurquoise;
            bunifuTileButton1.Cursor = Cursors.Hand;
            bunifuTileButton1.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuTileButton1.ForeColor = SystemColors.MenuHighlight;
            bunifuTileButton1.Image = Properties.Resources.Y;
            bunifuTileButton1.ImagePosition = -55;
            bunifuTileButton1.ImageZoom = 150;
            bunifuTileButton1.LabelPosition = 51;
            bunifuTileButton1.LabelText = "Yatri P1";
            bunifuTileButton1.Location = new Point(47, 184);
            bunifuTileButton1.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton1.Name = "bunifuTileButton1";
            bunifuTileButton1.Size = new Size(159, 194);
            bunifuTileButton1.TabIndex = 47;
            bunifuTileButton1.Click += bunifuTileButton1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Yu Gothic UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkTurquoise;
            label3.Location = new Point(6, 60);
            label3.Name = "label3";
            label3.Size = new Size(189, 40);
            label3.TabIndex = 37;
            label3.Text = "Electric Bikes";
            // 
            // electricBike
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 580);
            Controls.Add(panelContainer);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "electricBike";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "electricBike";
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelContainer.ResumeLayout(false);
            panelContainer.PerformLayout();
            gradientPanel3.ResumeLayout(false);
            gradientPanel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private gradientPanel gradientPanel1;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton helpBtn;
        private FontAwesome.Sharp.IconButton motorcyceBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton userButton;
        private Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private Panel panelContainer;
        private gradientPanel gradientPanel3;
        private Label label1;
        private gradientPanel gradientPanel4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private Panel panel2;
        private Label label2;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Label label3;
    }
}