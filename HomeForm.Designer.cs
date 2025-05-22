namespace AntdUIDemo
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel1 = new AntdUI.Panel();
            this.welcomeLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.labelTime1 = new AntdUI.LabelTime();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelTime1);
            this.panel1.Controls.Add(this.welcomeLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.panel1.Radius = 20;
            this.panel1.Size = new System.Drawing.Size(821, 655);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Satoshi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(81, 48);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(131, 38);
            this.welcomeLabel.TabIndex = 11;
            this.welcomeLabel.Text = "Welcome";
            // 
            // labelTime1
            // 
            this.labelTime1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime1.BackColor = System.Drawing.Color.Transparent;
            this.labelTime1.Location = new System.Drawing.Point(611, 48);
            this.labelTime1.Name = "labelTime1";
            this.labelTime1.Size = new System.Drawing.Size(167, 38);
            this.labelTime1.TabIndex = 12;
            this.labelTime1.Text = "labelTime1";
            // 
            // HomeForm
            // 
            this.ClientSize = new System.Drawing.Size(821, 655);
            this.Controls.Add(this.panel1);
            this.Dark = true;
            this.EnableHitTest = false;
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Mode = AntdUI.TAMode.Dark;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel1;
        private Siticone.UI.WinForms.SiticoneLabel welcomeLabel;
        private AntdUI.LabelTime labelTime1;
    }
}