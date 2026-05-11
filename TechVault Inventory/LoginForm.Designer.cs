namespace TechVaultManagement
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F,
                System.Drawing.FontStyle.Bold);

            this.lblTitle.ForeColor =
                System.Drawing.Color.FromArgb(39, 55, 77);

            this.lblTitle.Location =
                new System.Drawing.Point(40, 60);

            this.lblTitle.Text = "TECHVAULT MANAGEMENT";

            // cmbUserType
            this.cmbUserType.Items.AddRange(new object[] {
            "Admin",
            "Customer"});

            this.cmbUserType.Location =
                new System.Drawing.Point(80, 160);

            this.cmbUserType.Size =
                new System.Drawing.Size(250, 30);

            // btnLogin
            this.btnLogin.Text = "LOGIN";

            this.btnLogin.BackColor =
                System.Drawing.Color.FromArgb(39, 55, 77);

            this.btnLogin.ForeColor =
                System.Drawing.Color.White;

            this.btnLogin.FlatStyle =
                System.Windows.Forms.FlatStyle.Flat;

            this.btnLogin.Location =
                new System.Drawing.Point(80, 220);

            this.btnLogin.Size =
                new System.Drawing.Size(250, 45);

            this.btnLogin.Click +=
                new System.EventHandler(this.btnLogin_Click);

            // LoginForm
            this.AutoScaleDimensions =
                new System.Drawing.SizeF(7F, 15F);

            this.AutoScaleMode =
                System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize =
                new System.Drawing.Size(420, 400);

            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.cmbUserType);
            this.Controls.Add(this.btnLogin);

            this.Name = "LoginForm";

            this.Text = "TechVault Management";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}