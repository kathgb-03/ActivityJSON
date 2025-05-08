using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GroceryListApp
{
    public partial class Form2 : Form
    {
        private readonly List<Product> products = new List<Product>();

        public Form2()
        {
            InitializeComponent();

            txtId.Text = "Enter ID";
            txtName.Text = "Enter Name";
            txtPrice.Text = "Enter Price";

            txtId.GotFocus += RemovePlaceholderText;
            txtName.GotFocus += RemovePlaceholderText;
            txtPrice.GotFocus += RemovePlaceholderText;

            txtId.LostFocus += AddPlaceholderText;
            txtName.LostFocus += AddPlaceholderText;
            txtPrice.LostFocus += AddPlaceholderText;
        }

        private void RemovePlaceholderText(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (txt.Text == "Enter ID" || txt.Text == "Enter Name" || txt.Text == "Enter Price")
                txt.Text = "";
        }

        private void AddPlaceholderText(object sender, EventArgs e)
        {
            var txt = sender as TextBox;
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                if (txt == txtId) txt.Text = "Enter ID";
                if (txt == txtName) txt.Text = "Enter Name";
                if (txt == txtPrice) txt.Text = "Enter Price";
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (products.Count >= 5)
            {
                lblStatus.Text = "Maximum of 5 items allowed.";
                return;
            }

            if (int.TryParse(txtId.Text, out int id) &&
                !string.IsNullOrWhiteSpace(txtName.Text) &&
                double.TryParse(txtPrice.Text, out double price))
            {
                products.Add(new Product { Id = id, Name = txtName.Text, Price = price });
                lblStatus.Text = $"Added ({products.Count}/5)";
                txtId.Text = "Enter ID";
                txtName.Text = "Enter Name";
                txtPrice.Text = "Enter Price";
            }
            else
            {
                lblStatus.Text = "Invalid input. Please check all fields.";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (products.Count == 0)
            {
                lblStatus.Text = "No items to save.";
                return;
            }

            JsonHelper.WriteProducts(products);
            lblStatus.Text = "Saved to shoppinglist.json!";
            products.Clear();
        }
    }
}
