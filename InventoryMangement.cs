using AntdUI;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using System.Drawing;
using CSCISystem1._1;


namespace AntdUIDemo
{
    public partial class InventoryMangement : AntdUI.Window
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;

        public InventoryMangement()
        {
            InitializeComponent();
            
            Loadform(new HomeForm());
            
        }

        private void loadingTimer_Tick(object sender, EventArgs e)
        {

        }

        private void Loadform(AntdUI.Window window)
        {
            if (this.mainPanel.Controls.Count > 0)
                this.mainPanel.Controls.RemoveAt(0);
            
            window.TopLevel = false;
            window.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(window);
            this.mainPanel.Tag = window;
            window.Show();
        }     

        bool reportExpand = false;
        private void dropDownTimer_Tick(object sender, EventArgs e)
        {
            if (reportExpand == false)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Height >= 279)
                {
                    dropDownTimer.Stop();
                    reportExpand = true;
                }
            }
            else
            {
                panelDropDown.Height -= 10;
                if (panelDropDown.Height <= 185)
                {
                    dropDownTimer.Stop();
                    reportExpand = false;
                }
            }
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Loadform(new HomeForm());
        }

        private void ProductBtn_Click(object sender, EventArgs e)
        {
            Loadform(new ProductForm());
        }

        private void UserBtn_Click(object sender, EventArgs e)
        {
            Loadform(new UserForm());
        }

        private void ReportBtn_Click(object sender, EventArgs e)
        {
            dropDownTimer.Start();
        }

        private void InventoryRBtn_Click(object sender, EventArgs e)
        {

        }

        private void SalesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
