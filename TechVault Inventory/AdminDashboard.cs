using MySqlConnector;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechVaultManagement
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(221, 230, 237);

            LoadProducts();
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query = "SELECT * FROM products";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                decimal total =
                    Convert.ToInt32(txtQuantity.Text) *
                    Convert.ToDecimal(txtUnitPrice.Text);

                string query =
                    "INSERT INTO products " +
                    "(product_code, product_name, category, quantity, unit_price, total_price, date_added) " +
                    "VALUES " +
                    "(@code, @name, @category, @qty, @unit, @total, @date)";

                MySqlCommand cmd =
                    new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                cmd.Parameters.AddWithValue("@qty", txtQuantity.Text);
                cmd.Parameters.AddWithValue("@unit", txtUnitPrice.Text);
                cmd.Parameters.AddWithValue("@total", total);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Product Added");

                LoadProducts();

                ClearFields();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                string query =
                    "SELECT * FROM products " +
                    "WHERE product_name LIKE @search " +
                    "OR category LIKE @search " +
                    "OR product_code LIKE @search";

                MySqlDataAdapter adapter =
                    new MySqlDataAdapter(query, conn);

                adapter.SelectCommand.Parameters.AddWithValue(
                    "@search",
                    "%" + txtSearch.Text + "%");

                DataTable table = new DataTable();

                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
        }

        private void ClearFields()
        {
            txtCode.Clear();
            txtName.Clear();
            txtCategory.Clear();
            txtQuantity.Clear();
            txtUnitPrice.Clear();
        }
    }
}