using MySqlConnector;

namespace TechVaultManagement
{
    public class DBConnection
    {
        public static MySqlConnection GetConnection()
        {
            string conn =
                "server=localhost;user=root;password=;database=techvaultdb;";

            return new MySqlConnection(conn);
        }
    }
}