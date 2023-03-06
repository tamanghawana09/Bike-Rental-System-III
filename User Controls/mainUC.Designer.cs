using System.Windows.Forms.DataVisualization.Charting;
namespace bikeRental.User_Controls
{
    partial class mainUC
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
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            panel2 = new Panel();
            label1 = new Label();
            gradientPanel2 = new gradientPanel();
            label11 = new Label();
            label2 = new Label();
            gradientPanel3 = new gradientPanel();
            panel1 = new Panel();
            chart6 = new Chart();
            label3 = new Label();
            label4 = new Label();
            linkLabel1 = new LinkLabel();
            gradientPanel1 = new gradientPanel();
            panel3 = new Panel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            pbar1 = new CircularProgressBar.CircularProgressBar();
            gradientPanel4 = new gradientPanel();
            panel4 = new Panel();
            bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(components);
            bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(components);
            timer1 = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            gradientPanel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart6).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
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
            panel2.TabIndex = 3;
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
            // gradientPanel2
            // 
            gradientPanel2.Angle = 0F;
            gradientPanel2.BottomColor = Color.White;
            gradientPanel2.Controls.Add(label11);
            gradientPanel2.Dock = DockStyle.Bottom;
            gradientPanel2.Location = new Point(0, 541);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(933, 39);
            gradientPanel2.TabIndex = 5;
            gradientPanel2.TopColor = Color.White;
            gradientPanel2.Paint += gradientPanel2_Paint;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Yu Gothic UI Semilight", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkTurquoise;
            label11.Location = new Point(618, 9);
            label11.Name = "label11";
            label11.Size = new Size(262, 20);
            label11.TabIndex = 0;
            label11.Text = "All Rights Reserved. Bike Rental System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Yu Gothic UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkTurquoise;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(108, 45);
            label2.TabIndex = 11;
            label2.Text = "Home";
            // 
            // gradientPanel3
            // 
            gradientPanel3.Angle = 0F;
            gradientPanel3.BackColor = Color.Cyan;
            gradientPanel3.BackgroundImageLayout = ImageLayout.None;
            gradientPanel3.BottomColor = Color.Empty;
            gradientPanel3.Location = new Point(11, 58);
            gradientPanel3.Name = "gradientPanel3";
            gradientPanel3.Size = new Size(545, 10);
            gradientPanel3.TabIndex = 12;
            gradientPanel3.TopColor = Color.MediumBlue;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(chart6);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(590, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 447);
            panel1.TabIndex = 14;
            // 
            // chart6
            // 
            chartArea1.Name = "ChartArea1";
            chart6.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart6.Legends.Add(legend1);
            chart6.Location = new Point(13, 111);
            chart6.Name = "chart6";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = SeriesChartType.Doughnut;
            series1.Font = new Font("Yu Gothic UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            series1.LabelBackColor = Color.Transparent;
            series1.LabelBorderWidth = 10;
            series1.LabelForeColor = Color.White;
            series1.Legend = "Legend1";
            series1.MarkerBorderWidth = 5;
            series1.MarkerSize = 10;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 5;
            chart6.Series.Add(series1);
            chart6.Size = new Size(313, 300);
            chart6.TabIndex = 15;
            chart6.Text = "chart6";
            chart6.Click += chart6_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Yu Gothic UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 192, 192);
            label3.Location = new Point(13, 11);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 14;
            label3.Text = "Other Activity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.DodgerBlue;
            label4.Location = new Point(11, 76);
            label4.Name = "label4";
            label4.Size = new Size(197, 32);
            label4.TabIndex = 14;
            label4.Text = "Top Rented Bikes";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkColor = Color.FromArgb(0, 0, 192);
            linkLabel1.Location = new Point(12, 9);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(65, 25);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "MT-15";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // gradientPanel1
            // 
            gradientPanel1.Angle = 0F;
            gradientPanel1.BackColor = Color.Cyan;
            gradientPanel1.BackgroundImageLayout = ImageLayout.None;
            gradientPanel1.BottomColor = Color.Empty;
            gradientPanel1.Location = new Point(11, 170);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(545, 5);
            gradientPanel1.TabIndex = 12;
            gradientPanel1.TopColor = Color.Cyan;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(linkLabel4);
            panel3.Controls.Add(linkLabel3);
            panel3.Controls.Add(linkLabel2);
            panel3.Controls.Add(linkLabel1);
            panel3.Location = new Point(20, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(536, 43);
            panel3.TabIndex = 16;
            // 
            // linkLabel4
            // 
            linkLabel4.ActiveLinkColor = Color.Black;
            linkLabel4.AutoSize = true;
            linkLabel4.Cursor = Cursors.Hand;
            linkLabel4.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel4.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel4.LinkColor = Color.FromArgb(255, 128, 0);
            linkLabel4.Location = new Point(370, 9);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(140, 25);
            linkLabel4.TabIndex = 15;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "KTM Duke 390";
            linkLabel4.LinkClicked += linkLabel4_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Black;
            linkLabel3.AutoSize = true;
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel3.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel3.LinkColor = Color.Gray;
            linkLabel3.Location = new Point(230, 9);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(134, 25);
            linkLabel3.TabIndex = 15;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "RE Classic 350";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkColor = Color.Red;
            linkLabel2.Location = new Point(98, 9);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(108, 25);
            linkLabel2.TabIndex = 15;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Honda CRF";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.DodgerBlue;
            label5.Location = new Point(23, 266);
            label5.Name = "label5";
            label5.Size = new Size(115, 32);
            label5.TabIndex = 14;
            label5.Text = "Summary";
            // 
            // bunifuTileButton1
            // 
            bunifuTileButton1.BackColor = Color.White;
            bunifuTileButton1.color = Color.White;
            bunifuTileButton1.colorActive = Color.FromArgb(0, 192, 192);
            bunifuTileButton1.Cursor = Cursors.Hand;
            bunifuTileButton1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuTileButton1.ForeColor = Color.FromArgb(0, 0, 192);
            bunifuTileButton1.Image = Properties.Resources.mt;
            bunifuTileButton1.ImagePosition = 0;
            bunifuTileButton1.ImageZoom = 100;
            bunifuTileButton1.LabelPosition = 45;
            bunifuTileButton1.LabelText = "Petrol Bikes";
            bunifuTileButton1.Location = new Point(241, 306);
            bunifuTileButton1.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton1.Name = "bunifuTileButton1";
            bunifuTileButton1.Size = new Size(145, 185);
            bunifuTileButton1.TabIndex = 17;
            bunifuTileButton1.Click += bunifuTileButton1_Click;
            // 
            // bunifuTileButton2
            // 
            bunifuTileButton2.BackColor = Color.White;
            bunifuTileButton2.color = Color.White;
            bunifuTileButton2.colorActive = Color.FromArgb(0, 192, 192);
            bunifuTileButton2.Cursor = Cursors.Hand;
            bunifuTileButton2.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            bunifuTileButton2.ForeColor = Color.FromArgb(0, 0, 192);
            bunifuTileButton2.Image = Properties.Resources.Super_Soco;
            bunifuTileButton2.ImagePosition = 0;
            bunifuTileButton2.ImageZoom = 100;
            bunifuTileButton2.LabelPosition = 45;
            bunifuTileButton2.LabelText = "Electric Bikes";
            bunifuTileButton2.Location = new Point(423, 306);
            bunifuTileButton2.Margin = new Padding(6, 8, 6, 8);
            bunifuTileButton2.Name = "bunifuTileButton2";
            bunifuTileButton2.Size = new Size(145, 185);
            bunifuTileButton2.TabIndex = 17;
            bunifuTileButton2.Click += bunifuTileButton2_Click;
            // 
            // pbar1
            // 
            pbar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            pbar1.AnimationSpeed = 500;
            pbar1.BackColor = Color.White;
            pbar1.Font = new Font("Yu Gothic UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            pbar1.ForeColor = Color.FromArgb(64, 64, 64);
            pbar1.InnerColor = Color.White;
            pbar1.InnerMargin = 2;
            pbar1.InnerWidth = -1;
            pbar1.Location = new Point(23, 306);
            pbar1.MarqueeAnimationSpeed = 2000;
            pbar1.Name = "pbar1";
            pbar1.OuterColor = Color.Silver;
            pbar1.OuterMargin = -25;
            pbar1.OuterWidth = 26;
            pbar1.ProgressColor = Color.FromArgb(0, 192, 192);
            pbar1.ProgressWidth = 25;
            pbar1.SecondaryFont = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pbar1.Size = new Size(185, 185);
            pbar1.StartAngle = 270;
            pbar1.SubscriptColor = Color.Empty;
            pbar1.SubscriptMargin = new Padding(10, -35, 0, 0);
            pbar1.SubscriptText = "";
            pbar1.SuperscriptColor = Color.Empty;
            pbar1.SuperscriptMargin = new Padding(10, 35, 0, 0);
            pbar1.SuperscriptText = "";
            pbar1.TabIndex = 18;
            pbar1.TextMargin = new Padding(0);
            pbar1.Value = 68;
            pbar1.Click += pbar_Click;
            // 
            // gradientPanel4
            // 
            gradientPanel4.Angle = 0F;
            gradientPanel4.BackColor = Color.MediumBlue;
            gradientPanel4.BackgroundImageLayout = ImageLayout.None;
            gradientPanel4.BottomColor = Color.Empty;
            gradientPanel4.Location = new Point(20, 508);
            gradientPanel4.Name = "gradientPanel4";
            gradientPanel4.Size = new Size(548, 10);
            gradientPanel4.TabIndex = 12;
            gradientPanel4.TopColor = Color.Cyan;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(gradientPanel3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(panel3);
            panel4.Controls.Add(gradientPanel1);
            panel4.Location = new Point(12, 74);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 189);
            panel4.TabIndex = 15;
            // 
            // bunifuElipse1
            // 
            bunifuElipse1.ElipseRadius = 10;
            bunifuElipse1.TargetControl = panel4;
            // 
            // bunifuElipse2
            // 
            bunifuElipse2.ElipseRadius = 10;
            bunifuElipse2.TargetControl = panel1;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // mainUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 248);
            Controls.Add(gradientPanel4);
            Controls.Add(bunifuTileButton2);
            Controls.Add(pbar1);
            Controls.Add(bunifuTileButton1);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(gradientPanel2);
            Controls.Add(panel2);
            Controls.Add(label5);
            Name = "mainUC";
            Size = new Size(933, 580);
            Load += mainUC_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private gradientPanel gradientPanel2;
        private Label label11;
        private Label label2;
        private gradientPanel gradientPanel3;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private LinkLabel linkLabel1;
        private gradientPanel gradientPanel1;
        private Panel panel3;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private Label label5;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        private Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        private CircularProgressBar.CircularProgressBar pbar1;
        private gradientPanel gradientPanel4;
        private Panel panel4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Timer timer1;
        //private System.CodeDom.CodeTypeReference chart1;
        //private System.CodeDom.CodeTypeReference chart2;
        // private System.CodeDom.CodeTypeReference chart3;
        //private System.CodeDom.CodeTypeReference chartDetails;
        //private System.CodeDom.CodeTypeReference chart4;
        //private System.CodeDom.CodeTypeReference chart5;
        private Chart chart6;
        //private System.CodeDom.CodeTypeReference chart4;
    }
}
