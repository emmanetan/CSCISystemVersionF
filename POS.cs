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
        public POS()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        public void InitializeDataGridView()
        {
            
            gridViewProductList.Columns.Add("ProductName", "   Item Name");
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Amount");
           
        }
    }
}
