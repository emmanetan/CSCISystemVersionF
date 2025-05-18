using AntdUI;
using CSCISystem1._1;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.Data.SqlClient;


namespace AntdUIDemo
{
    public partial class ProductForm : AntdUI.Window
    {
        SqlConnection con = new SqlConnection("Data Source = EMMAN\\SQLEXPRESS; Initial Catalog = DB_System; Integrated Security = True; Encrypt=True;Trust Server Certificate=True");
        SqlCommand cmd;

        public ProductForm()
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

            con.Open();
            string query = "SELECT ProductCode, ProductName, ExpDate, Quantity, Price, TotalPrice FROM tb_product";
            cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();

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


        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

        }
    }
}
