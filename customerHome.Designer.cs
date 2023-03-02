namespace bikeRental
{
    partial class customerHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerHome));
            gradientPanel1 = new gradientPanel();
            pictureBox1 = new PictureBox();
            logoutBtn = new FontAwesome.Sharp.IconButton();
            helpBtn = new FontAwesome.Sharp.IconButton();
            motorcyceBtn = new FontAwesome.Sharp.IconButton();
            homeBtn = new FontAwesome.Sharp.IconButton();
            userButton = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            panelContainer = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(components);
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            gradientPanel1.TabIndex = 1;
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
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(67, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(933, 580);
            panelContainer.TabIndex = 2;
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
            // customerHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            ClientSize = new Size(1000, 580);
            Controls.Add(panelContainer);
            Controls.Add(gradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "customerHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "customerHome";
            Load += customerHome_Load;
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panelContainer;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
    }
}