using AntdUI;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;



namespace AntdUIDemo
{
    public partial class POS : AntdUI.Window
    {
        SqlConnection _con = new SqlConnection(
                "Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");

        SqlCommand _cmd;

        public POS()
        {
            InitializeComponent();
            LoadMOP();
            
        }

        private void LoadMOP()
        {
            
            mopDropdown.Items.Add("Cash");

        }

        private void POS_Load(object sender, EventArgs e)
        {
            txtSearchItem.Focus();
            LoadReceipt();
        }

        private void LoadReceipt()
        {
            receiptTextBox.Clear();
            receiptTextBox.Text += "Address: Legazpi City \n";
            receiptTextBox.Text += "Tel: 999-685-0001\n";
            receiptTextBox.Text += "----------------------------------------\n";
            receiptTextBox.Text += "Date: " + DateTime.Now + "\n";
            receiptTextBox.Text += "----------------------------------------\n\n";
            receiptTextBox.Text += "Item\t\t" + "Qty.\t\t" + "Price\t\n";
            receiptTextBox.Text += "----------------------------------------\n";
        }


    }
}
