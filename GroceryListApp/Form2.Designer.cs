namespace GroceryListApp
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtId.Location = new System.Drawing.Point(30, 20);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(220, 22);

            this.txtName.Location = new System.Drawing.Point(30, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 22);

            this.txtPrice.Location = new System.Drawing.Point(30, 80);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(220, 22);

            this.btnAddToList.Location = new System.Drawing.Point(30, 110);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(100, 30);
            this.btnAddToList.Text = "Add to List";
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);

            this.btnSave.Location = new System.Drawing.Point(150, 110);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.lblStatus.Location = new System.Drawing.Point(30, 150);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 30);
            this.lblStatus.Text = "Status here";

            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form2";
            this.Text = "Add Groceries";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
