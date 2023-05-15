namespace AdminRentalUI.Customer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customerHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.userButton = new FontAwesome.Sharp.IconButton();
            this.homeBtn = new FontAwesome.Sharp.IconButton();
            this.motorcycleBtn = new FontAwesome.Sharp.IconButton();
            this.helpBtn = new FontAwesome.Sharp.IconButton();
            this.logoutBtn = new FontAwesome.Sharp.IconButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse6 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AdminRentalUI.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 69);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 0;
            this.bunifuGradientPanel1.Controls.Add(this.logoutBtn);
            this.bunifuGradientPanel1.Controls.Add(this.helpBtn);
            this.bunifuGradientPanel1.Controls.Add(this.motorcycleBtn);
            this.bunifuGradientPanel1.Controls.Add(this.homeBtn);
            this.bunifuGradientPanel1.Controls.Add(this.userButton);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.MediumBlue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(67, 580);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // userButton
            // 
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userButton.IconColor = System.Drawing.Color.Navy;
            this.userButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userButton.IconSize = 27;
            this.userButton.Location = new System.Drawing.Point(3, 182);
            this.userButton.Name = "userButton";
            this.userButton.Padding = new System.Windows.Forms.Padding(20);
            this.userButton.Size = new System.Drawing.Size(60, 45);
            this.userButton.TabIndex = 1;
            this.userButton.UseVisualStyleBackColor = true;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            this.userButton.Enter += new System.EventHandler(this.userButton_Enter);
            this.userButton.Leave += new System.EventHandler(this.userButton_Leave);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.homeBtn.IconColor = System.Drawing.Color.Navy;
            this.homeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.homeBtn.IconSize = 27;
            this.homeBtn.Location = new System.Drawing.Point(3, 233);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Padding = new System.Windows.Forms.Padding(20);
            this.homeBtn.Size = new System.Drawing.Size(60, 45);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            this.homeBtn.Enter += new System.EventHandler(this.homeBtn_Enter);
            this.homeBtn.Leave += new System.EventHandler(this.homeBtn_Leave);
            // 
            // motorcycleBtn
            // 
            this.motorcycleBtn.FlatAppearance.BorderSize = 0;
            this.motorcycleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.motorcycleBtn.IconChar = FontAwesome.Sharp.IconChar.Motorcycle;
            this.motorcycleBtn.IconColor = System.Drawing.Color.Navy;
            this.motorcycleBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.motorcycleBtn.IconSize = 27;
            this.motorcycleBtn.Location = new System.Drawing.Point(4, 284);
            this.motorcycleBtn.Name = "motorcycleBtn";
            this.motorcycleBtn.Padding = new System.Windows.Forms.Padding(20);
            this.motorcycleBtn.Size = new System.Drawing.Size(60, 45);
            this.motorcycleBtn.TabIndex = 1;
            this.motorcycleBtn.UseVisualStyleBackColor = true;
            this.motorcycleBtn.Click += new System.EventHandler(this.motorcycleBtn_Click);
            this.motorcycleBtn.Enter += new System.EventHandler(this.motorcycleBtn_Enter);
            this.motorcycleBtn.Leave += new System.EventHandler(this.motorcycleBtn_Leave);
            // 
            // helpBtn
            // 
            this.helpBtn.FlatAppearance.BorderSize = 0;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.helpBtn.IconColor = System.Drawing.Color.Navy;
            this.helpBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.helpBtn.IconSize = 27;
            this.helpBtn.Location = new System.Drawing.Point(3, 335);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Padding = new System.Windows.Forms.Padding(20);
            this.helpBtn.Size = new System.Drawing.Size(60, 45);
            this.helpBtn.TabIndex = 1;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            this.helpBtn.Enter += new System.EventHandler(this.helpBtn_Enter);
            this.helpBtn.Leave += new System.EventHandler(this.helpBtn_Leave);
            // 
            // logoutBtn
            // 
            this.logoutBtn.FlatAppearance.BorderSize = 0;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.IconChar = FontAwesome.Sharp.IconChar.ArrowRightFromBracket;
            this.logoutBtn.IconColor = System.Drawing.Color.White;
            this.logoutBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutBtn.IconSize = 27;
            this.logoutBtn.Location = new System.Drawing.Point(4, 535);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Padding = new System.Windows.Forms.Padding(20);
            this.logoutBtn.Size = new System.Drawing.Size(60, 45);
            this.logoutBtn.TabIndex = 1;
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            this.logoutBtn.Enter += new System.EventHandler(this.logoutBtn_Enter);
            this.logoutBtn.Leave += new System.EventHandler(this.logoutBtn_Leave);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this.logoutBtn;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 42;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this.helpBtn;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 20;
            this.bunifuElipse4.TargetControl = this.homeBtn;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 20;
            this.bunifuElipse5.TargetControl = this.motorcycleBtn;
            // 
            // bunifuElipse6
            // 
            this.bunifuElipse6.ElipseRadius = 20;
            this.bunifuElipse6.TargetControl = this.userButton;
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(67, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(933, 580);
            this.panelContainer.TabIndex = 1;
            // 
            // customerHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customerHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton logoutBtn;
        private FontAwesome.Sharp.IconButton helpBtn;
        private FontAwesome.Sharp.IconButton motorcycleBtn;
        private FontAwesome.Sharp.IconButton homeBtn;
        private FontAwesome.Sharp.IconButton userButton;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse6;
        private System.Windows.Forms.Panel panelContainer;
    }
}