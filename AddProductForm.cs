using Siticone.UI.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSCISystem1._1
{
    public partial class AddProductForm: Form
    {

        public AddProductForm()
        {
            InitializeComponent();
            RadiusForm();
            CalculateTotalPrice();
            LoadDay();
            LoadMonth();
            LoadYear();
            
        }
        
       
        private void RadiusForm()
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 18;

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 272, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();

            Region = new Region(path);
        }

        private void CalculateTotalPrice()
        {
            string quantityText = txtQuantity.Text.Trim();
            string priceText = txtPrice.Text.Trim();

            if (int.TryParse(quantityText, out int quantity) &&
                decimal.TryParse(priceText, out decimal price) &&
                quantity > 0 && price > 0)
            {
                decimal totalPrice = quantity * price;
                txtTotalPrice.Text = totalPrice.ToString("0.00");
            }
            else
            {
                txtTotalPrice.Text = "0.00";
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void LoadDay()
        {
            
            dayComboBox.SelectedIndex = 0;

            // looping from 1 to 31
            for (int i = 1; i <= 31; i++)
            {
                dayComboBox.Items.Add(i);
            }            
        }
        private void LoadMonth()
        {
            
            monthComboBox.SelectedIndex = 0;

            // looping from 1 to 12
            for (int i = 1; i <= 12; i++)
            {
                monthComboBox.Items.Add(i);
            }
        }
        private void LoadYear()
        {
            // looping from 2025 to 1900
            
            yearComboBox.SelectedIndex = 0;
            for (int i = 2025; i <= 2045; i++)
            {
                yearComboBox.Items.Add(i);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txtPrice.Clear();
            txtProductCode.Clear();
            txtProductName.Clear();
            txtQuantity.Clear();
            txtTotalPrice.Clear();
            dayComboBox.SelectedIndex = -1;
            monthComboBox.SelectedIndex = -1;
            yearComboBox.SelectedIndex = -1;
            
            txtProductCode.Focus();

        }
    }
}
