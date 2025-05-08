using System;
using System.Windows.Forms;

namespace GroceryListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadJson_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();
            var products = JsonHelper.ReadProducts();
            foreach (var p in products)
                lstDisplay.Items.Add($"{p.Id}: {p.Name} - ₱{p.Price:F2}");
        }

        private void btnOpenForm2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
