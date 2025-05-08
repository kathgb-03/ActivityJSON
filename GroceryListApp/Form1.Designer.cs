namespace GroceryListApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnLoadJson;
        private System.Windows.Forms.ListBox lstDisplay;
        private System.Windows.Forms.Button btnOpenForm2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnLoadJson = new System.Windows.Forms.Button();
            this.lstDisplay = new System.Windows.Forms.ListBox();
            this.btnOpenForm2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadJson
            // 
            this.btnLoadJson.Location = new System.Drawing.Point(30, 20);
            this.btnLoadJson.Name = "btnLoadJson";
            this.btnLoadJson.Size = new System.Drawing.Size(140, 30);
            this.btnLoadJson.Text = "Load Grocery List";
            this.btnLoadJson.UseVisualStyleBackColor = true;
            this.btnLoadJson.Click += new System.EventHandler(this.btnLoadJson_Click);
            // 
            // lstDisplay
            // 
            this.lstDisplay.FormattingEnabled = true;
            this.lstDisplay.ItemHeight = 16;
            this.lstDisplay.Location = new System.Drawing.Point(30, 60);
            this.lstDisplay.Size = new System.Drawing.Size(300, 180);
            // 
            // btnOpenForm2
            // 
            this.btnOpenForm2.Location = new System.Drawing.Point(190, 20);
            this.btnOpenForm2.Size = new System.Drawing.Size(140, 30);
            this.btnOpenForm2.Text = "Add Groceries";
            this.btnOpenForm2.UseVisualStyleBackColor = true;
            this.btnOpenForm2.Click += new System.EventHandler(this.btnOpenForm2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 260);
            this.Controls.Add(this.btnLoadJson);
            this.Controls.Add(this.btnOpenForm2);
            this.Controls.Add(this.lstDisplay);
            this.Name = "Form1";
            this.Text = "Grocery List Viewer";
            this.ResumeLayout(false);
        }
    }
}
