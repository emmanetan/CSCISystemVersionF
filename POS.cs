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
    }
}
