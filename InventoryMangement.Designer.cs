namespace AntdUIDemo
{
    partial class InventoryMangement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryMangement));
            this.titlebar = new AntdUI.PageHeader();
            this.siticoneControlBox2 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.mainPanel = new AntdUI.Panel();
            this.menuPanel = new AntdUI.Panel();
            this.button1 = new AntdUI.Button();
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.panelDropDown = new System.Windows.Forms.FlowLayoutPanel();
            this.HomeBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ProductBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.UserBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.ReportBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.InventoryRBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.SalesBtn = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.loadingTimer = new System.Windows.Forms.Timer(this.components);
            this.dropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.titlebar.SuspendLayout();
            this.siticonePanel1.SuspendLayout();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.titlebar.CloseSize = 35;
            this.titlebar.Controls.Add(this.siticoneControlBox2);
            this.titlebar.Controls.Add(this.siticoneControlBox1);
            this.titlebar.DividerShow = true;
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.DragMove = false;
            this.titlebar.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.titlebar.Location = new System.Drawing.Point(0, 0);
            this.titlebar.MaximizeBox = false;
            this.titlebar.Name = "titlebar";
            this.titlebar.ShowIcon = true;
            this.titlebar.Size = new System.Drawing.Size(1160, 29);
            this.titlebar.SubGap = 5;
            this.titlebar.SubText = "Inventory Management";
            this.titlebar.TabIndex = 1;
            this.titlebar.Text = "WiseMart";
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox2.HoveredState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox2.Location = new System.Drawing.Point(1062, -1);
            this.siticoneControlBox2.Name = "siticoneControlBox2";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(49, 29);
            this.siticoneControlBox2.TabIndex = 3;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(68)))), ((int)(((byte)(70)))));
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Black;
            this.siticoneControlBox1.Location = new System.Drawing.Point(1111, -1);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(49, 29);
            this.siticoneControlBox1.TabIndex = 2;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.mainPanel);
            this.siticonePanel1.Controls.Add(this.menuPanel);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 29);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.Padding = new System.Windows.Forms.Padding(10);
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(1160, 691);
            this.siticonePanel1.TabIndex = 2;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(313, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.mainPanel.Radius = 20;
            this.mainPanel.Size = new System.Drawing.Size(837, 671);
            this.mainPanel.TabIndex = 1;
            this.mainPanel.Text = "panel2";
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.siticonePictureBox1);
            this.menuPanel.Controls.Add(this.panelDropDown);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(10, 10);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Radius = 20;
            this.menuPanel.Size = new System.Drawing.Size(303, 671);
            this.menuPanel.TabIndex = 0;
            this.menuPanel.Text = "panel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "Temp POS";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticonePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox1.Image")));
            this.siticonePictureBox1.Location = new System.Drawing.Point(93, 32);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(106, 103);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 4;
            this.siticonePictureBox1.TabStop = false;
            // 
            // panelDropDown
            // 
            this.panelDropDown.BackColor = System.Drawing.Color.Transparent;
            this.panelDropDown.Controls.Add(this.HomeBtn);
            this.panelDropDown.Controls.Add(this.ProductBtn);
            this.panelDropDown.Controls.Add(this.UserBtn);
            this.panelDropDown.Controls.Add(this.ReportBtn);
            this.panelDropDown.Controls.Add(this.InventoryRBtn);
            this.panelDropDown.Controls.Add(this.SalesBtn);
            this.panelDropDown.Location = new System.Drawing.Point(16, 154);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelDropDown.Size = new System.Drawing.Size(267, 185);
            this.panelDropDown.TabIndex = 2;
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.Transparent;
            this.HomeBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.HomeBtn.CheckedState.Parent = this.HomeBtn;
            this.HomeBtn.CustomImages.Parent = this.HomeBtn;
            this.HomeBtn.FillColor = System.Drawing.Color.White;
            this.HomeBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HomeBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.HomeBtn.HoveredState.Parent = this.HomeBtn;
            this.HomeBtn.Image = ((System.Drawing.Image)(resources.GetObject("HomeBtn.Image")));
            this.HomeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.HomeBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.HomeBtn.Location = new System.Drawing.Point(6, 3);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.HomeBtn.ShadowDecoration.Parent = this.HomeBtn;
            this.HomeBtn.Size = new System.Drawing.Size(258, 40);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = " Home";
            this.HomeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.HomeBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.HomeBtn.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.Transparent;
            this.ProductBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.ProductBtn.CheckedState.Parent = this.ProductBtn;
            this.ProductBtn.CustomImages.Parent = this.ProductBtn;
            this.ProductBtn.FillColor = System.Drawing.Color.White;
            this.ProductBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ProductBtn.HoveredState.Parent = this.ProductBtn;
            this.ProductBtn.Image = ((System.Drawing.Image)(resources.GetObject("ProductBtn.Image")));
            this.ProductBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.ProductBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.ProductBtn.Location = new System.Drawing.Point(6, 49);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ProductBtn.ShadowDecoration.Parent = this.ProductBtn;
            this.ProductBtn.Size = new System.Drawing.Size(258, 40);
            this.ProductBtn.TabIndex = 1;
            this.ProductBtn.Text = " Product";
            this.ProductBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProductBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click);
            // 
            // UserBtn
            // 
            this.UserBtn.BackColor = System.Drawing.Color.Transparent;
            this.UserBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.UserBtn.CheckedState.Parent = this.UserBtn;
            this.UserBtn.CustomImages.Parent = this.UserBtn;
            this.UserBtn.FillColor = System.Drawing.Color.White;
            this.UserBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.UserBtn.HoveredState.Parent = this.UserBtn;
            this.UserBtn.Image = ((System.Drawing.Image)(resources.GetObject("UserBtn.Image")));
            this.UserBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.UserBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.UserBtn.Location = new System.Drawing.Point(6, 95);
            this.UserBtn.Name = "UserBtn";
            this.UserBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.UserBtn.ShadowDecoration.Parent = this.UserBtn;
            this.UserBtn.Size = new System.Drawing.Size(258, 40);
            this.UserBtn.TabIndex = 2;
            this.UserBtn.Text = " User";
            this.UserBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UserBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.UserBtn.Click += new System.EventHandler(this.UserBtn_Click);
            // 
            // ReportBtn
            // 
            this.ReportBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReportBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.ReportBtn.CheckedState.Parent = this.ReportBtn;
            this.ReportBtn.CustomImages.Parent = this.ReportBtn;
            this.ReportBtn.FillColor = System.Drawing.Color.White;
            this.ReportBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReportBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.ReportBtn.HoveredState.Parent = this.ReportBtn;
            this.ReportBtn.Image = ((System.Drawing.Image)(resources.GetObject("ReportBtn.Image")));
            this.ReportBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.ReportBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.ReportBtn.Location = new System.Drawing.Point(6, 141);
            this.ReportBtn.Name = "ReportBtn";
            this.ReportBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.ReportBtn.ShadowDecoration.Parent = this.ReportBtn;
            this.ReportBtn.Size = new System.Drawing.Size(258, 40);
            this.ReportBtn.TabIndex = 3;
            this.ReportBtn.Text = "Report";
            this.ReportBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ReportBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.ReportBtn.Click += new System.EventHandler(this.ReportBtn_Click);
            // 
            // InventoryRBtn
            // 
            this.InventoryRBtn.BackColor = System.Drawing.Color.Transparent;
            this.InventoryRBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.InventoryRBtn.CheckedState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.CustomImages.Parent = this.InventoryRBtn;
            this.InventoryRBtn.FillColor = System.Drawing.Color.White;
            this.InventoryRBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InventoryRBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InventoryRBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.InventoryRBtn.HoveredState.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Image = ((System.Drawing.Image)(resources.GetObject("InventoryRBtn.Image")));
            this.InventoryRBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.InventoryRBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.InventoryRBtn.Location = new System.Drawing.Point(47, 187);
            this.InventoryRBtn.Name = "InventoryRBtn";
            this.InventoryRBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.InventoryRBtn.ShadowDecoration.Parent = this.InventoryRBtn;
            this.InventoryRBtn.Size = new System.Drawing.Size(217, 40);
            this.InventoryRBtn.TabIndex = 4;
            this.InventoryRBtn.Text = "Inventory";
            this.InventoryRBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.InventoryRBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.InventoryRBtn.Click += new System.EventHandler(this.InventoryRBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.Transparent;
            this.SalesBtn.BorderColor = System.Drawing.Color.Turquoise;
            this.SalesBtn.CheckedState.Parent = this.SalesBtn;
            this.SalesBtn.CustomImages.Parent = this.SalesBtn;
            this.SalesBtn.FillColor = System.Drawing.Color.White;
            this.SalesBtn.Font = new System.Drawing.Font("Satoshi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalesBtn.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.SalesBtn.HoveredState.Parent = this.SalesBtn;
            this.SalesBtn.Image = ((System.Drawing.Image)(resources.GetObject("SalesBtn.Image")));
            this.SalesBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.ImageOffset = new System.Drawing.Point(18, 0);
            this.SalesBtn.ImageSize = new System.Drawing.Size(22, 21);
            this.SalesBtn.Location = new System.Drawing.Point(47, 233);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.SalesBtn.ShadowDecoration.Parent = this.SalesBtn;
            this.SalesBtn.Size = new System.Drawing.Size(217, 40);
            this.SalesBtn.TabIndex = 5;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SalesBtn.TextOffset = new System.Drawing.Point(25, 0);
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // loadingTimer
            // 
            this.loadingTimer.Interval = 1000;
            this.loadingTimer.Tick += new System.EventHandler(this.loadingTimer_Tick);
            // 
            // dropDownTimer
            // 
            this.dropDownTimer.Interval = 1;
            this.dropDownTimer.Tick += new System.EventHandler(this.dropDownTimer_Tick);
            // 
            // InventoryMangement
            // 
            this.ClientSize = new System.Drawing.Size(1160, 720);
            this.ControlBox = false;
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.titlebar);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "InventoryMangement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiseMart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.titlebar.ResumeLayout(false);
            this.siticonePanel1.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.PageHeader titlebar;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private AntdUI.Panel mainPanel;
        private AntdUI.Panel menuPanel;
        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private System.Windows.Forms.FlowLayoutPanel panelDropDown;
        private Siticone.UI.WinForms.SiticoneRoundedButton HomeBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton ProductBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton UserBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton ReportBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton InventoryRBtn;
        private Siticone.UI.WinForms.SiticoneRoundedButton SalesBtn;
        private System.Windows.Forms.Timer loadingTimer;
        private System.Windows.Forms.Timer dropDownTimer;
        private AntdUI.Button button1;
    }
}