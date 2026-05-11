using MySqlConnector;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TechVaultManagement
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();

            this.BackColor =
                Color.FromArgb(221, 230, 237);

            LoadProducts();
        }

        private void LoadProducts()
        {
            using (MySqlConnection conn =
                DBConnection.GetConnection())
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

        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            using (MySqlConnection conn =
                DBConnection.GetConnection())
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
    }
}