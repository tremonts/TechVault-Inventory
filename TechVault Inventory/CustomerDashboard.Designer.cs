namespace TechVaultManagement
{
    partial class CustomerDashboard
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.TextBox txtSearch;

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

            this.txtSearch =
                new System.Windows.Forms.TextBox();

            this.lblHeader =
                new System.Windows.Forms.Label();

            this.lblSearch =
                new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).BeginInit();

            this.SuspendLayout();

            // HEADER
            this.lblHeader.Text =
                "CUSTOMER DASHBOARD";

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

            // SEARCH LABEL
            this.lblSearch.Text = "Search";

            this.lblSearch.Location =
                new System.Drawing.Point(620, 75);

            this.lblSearch.AutoSize = true;

            this.lblSearch.Font =
                new System.Drawing.Font(
                    "Segoe UI",
                    10F,
                    System.Drawing.FontStyle.Bold);

            // SEARCH BOX
            this.txtSearch.Location =
                new System.Drawing.Point(690, 70);

            this.txtSearch.Size =
                new System.Drawing.Size(200, 27);

            this.txtSearch.PlaceholderText =
                "Search Product";

            this.txtSearch.TextChanged +=
                new System.EventHandler(this.txtSearch_TextChanged);

            // DATAGRIDVIEW
            this.dataGridView1.Location =
                new System.Drawing.Point(30, 120);

            this.dataGridView1.Size =
                new System.Drawing.Size(860, 350);

            this.dataGridView1.BackgroundColor =
                System.Drawing.Color.White;

            this.dataGridView1.AutoSizeColumnsMode =
                System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // FORM
            this.ClientSize =
                new System.Drawing.Size(930, 520);

            this.Controls.Add(this.lblHeader);

            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);

            this.Controls.Add(this.dataGridView1);

            this.Name = "CustomerDashboard";

            this.Text = "TechVault Management";

            ((System.ComponentModel.ISupportInitialize)
            (this.dataGridView1)).EndInit();

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}