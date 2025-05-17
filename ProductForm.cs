using AntdUI;
using CSCISystem1._1;
using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;

namespace AntdUIDemo
{
    public partial class ProductForm : AntdUI.Window
    {
        public ProductForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {

            gridViewProductList.Columns.Add("ProductCode", "Product Code");
            gridViewProductList.Columns.Add("ProductName", "Product Name");
            gridViewProductList.Columns.Add("MfgDate", "Manufacturing Date");
            gridViewProductList.Columns.Add("ExpDate", "Expiration Date");
            gridViewProductList.Columns.Add("Quantity", "Qty.");
            gridViewProductList.Columns.Add("Price", "Price");



            gridViewProductList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridViewProductList.AllowUserToAddRows = false;

            gridViewProductList.Rows.Add("P001", "C2 na green", "2024-01-01", "2026-05-05", 1, 100.00);
            gridViewProductList.Rows.Add("P002", "C2 na re", "2024-01-01", "2026-05-05", 20, 100.00);
            gridViewProductList.Rows.Add("D001", "Coke", "2025-01-01", "2028-05-05", 40, 100.00);

        }

        private void AddProductBtn_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();

        }
    }
}
