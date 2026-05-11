namespace TechVaultManagement
{
    partial class AdminDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtSearch;

        private System.Windows.Forms.Button btnAdd;

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblSearch;

        protected override void Dispose(bool disposing)
        {
            if (disposing &&
                (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dataGridView1 =
                new System.Windows.Forms.DataGridView();

            this.txtCode =
                new System.Windows.Forms.TextBox();

            this.txtName =
                new System.Windows.Forms.TextBox();

            this.txtCategory =
                new System.Windows.Forms.TextBox();

            this.txtQuantity =
                new System.Windows.Forms.TextBox();

            this.txtUnitPrice =
                new System.Windows.Forms.TextBox();

            this.txtSearch =
                new System.Windows.Forms.TextBox();

            this.btnAdd =
                new System.Windows.Forms.Button();

            this.lblHeader =
                new System.Windows.Forms.Label();

            this.lblSearch =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // HEADER
            this.lblHeader.Text =
                "ADMIN DASHBOARD";

            this.lblHeader.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    18F,
                    System.Drawing.FontStyle.Bold);

            this.lblHeader.ForeColor =
                System.Drawing.Color.White;

            this.lblHeader.BackColor =
                System.Drawing.Color.FromArgb(39, 55, 77);

            this.lblHeader.Dock =
                System.Windows.Forms.DockStyle.Top;

            this.lblHeader.Height = 60;

            this.lblHeader.TextAlign =
                System.Drawing.ContentAlignment.MiddleCenter;

            // PRODUCT CODE
            this.txtCode.Location =
                new System.Drawing.Point(30, 90);

            this.txtCode.Size =
                new System.Drawing.Size(120, 27);

            this.txtCode.PlaceholderText =
                "Product Code";

            // PRODUCT NAME
            this.txtName.Location =
                new System.Drawing.Point(170, 90);

            this.txtName.Size =
                new System.Drawing.Size(150, 27);

            this.txtName.PlaceholderText =
                "Product Name";

            // CATEGORY
            this.txtCategory.Location =
                new System.Drawing.Point(340, 90);

            this.txtCategory.Size =
                new System.Drawing.Size(120, 27);

            this.txtCategory.PlaceholderText =
                "Category";

            // QUANTITY
            this.txtQuantity.Location =
                new System.Drawing.Point(480, 90);

            this.txtQuantity.Size =
                new System.Drawing.Size(100, 27);

            this.txtQuantity.PlaceholderText =
                "Quantity";

            // UNIT PRICE
            this.txtUnitPrice.Location =
                new System.Drawing.Point(600, 90);

            this.txtUnitPrice.Size =
                new System.Drawing.Size(120, 27);

            this.txtUnitPrice.PlaceholderText =
                "Unit Price";

            // ADD BUTTON
            this.btnAdd.Text = "ADD";

            this.btnAdd.Location =
                new System.Drawing.Point(740, 88);

            this.btnAdd.Size =
                new System.Drawing.Size(100, 32);

            this.btnAdd.BackColor =
                System.Drawing.Color.FromArgb(82, 109, 130);

            this.btnAdd.ForeColor =
                System.Drawing.Color.White;

            this.btnAdd.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnAdd.Click +=
                new System.EventHandler(this.btnAdd_Click);

            // SEARCH LABEL
            this.lblSearch.Text = "Search";

            this.lblSearch.Location =
                new System.Drawing.Point(620, 135);

            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            // SEARCH BOX
            this.txtSearch.Location =
                new System.Drawing.Point(690, 130);

            this.txtSearch.Size =
                new System.Drawing.Size(200, 27);

            this.txtSearch.PlaceholderText =
                "Search Product";

            this.txtSearch.TextChanged +=
                new System.EventHandler(this.txtSearch_TextChanged);

            // DATAGRIDVIEW
            this.dataGridView1.Location =
                new System.Drawing.Point(30, 180);

            this.dataGridView1.Size =
                new System.Drawing.Size(860, 320);

            this.dataGridView1.BackgroundColor =
                System.Drawing.Color.White;

            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // FORM
            this.ClientSize =
                new System.Drawing.Size(930, 540);

            this.Controls.Add(this.lblHeader);

            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtUnitPrice);

            this.Controls.Add(this.btnAdd);

            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);

            this.Controls.Add(this.dataGridView1);

            this.Name = "AdminDashboard";

            this.Text = "TechVault Management";

            ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}