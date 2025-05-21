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
        SqlConnection _con =
            new SqlConnection(
                "Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");

        SqlCommand _cmd;

        public POS()
        {
            InitializeComponent();
            InitializeDataGridView();

        }

        public void InitializeDataGridView()
        {

            gridViewProductList.Columns.Add("ProductCode", "Item Code");
            gridViewProductList.Columns.Add("ProductName", "Item Name");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date");
            gridViewProductList.Columns.Add("Quantity", "Qty");
            gridViewProductList.Columns.Add("Price", "Unit Price");
            gridViewProductList.Columns.Add("TotalPrice", "Total Price");
            _con.Open();
            string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice FROM tb_product";
            _cmd = new SqlCommand(query, _con);
            SqlDataReader reader = _cmd.ExecuteReader();
            while (reader.Read())
            {
                gridViewProductList.Rows.Add(
                    reader["ProductCode"].ToString(),
                    reader["ProductName"].ToString(),
                    Convert.ToDateTime(reader["ExpDate"]).ToString("yyyy-MM-dd"),
                    reader["Quantity"].ToString(),
                    reader["Price"].ToString(),
                    reader["TotalPrice"].ToString()
                );
            }



        }
    }
}
