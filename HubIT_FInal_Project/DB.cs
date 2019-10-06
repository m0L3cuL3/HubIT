
using MySql.Data.MySqlClient;

namespace HubIT_FInal_Project
{
    /// <summary>
    /// This class manages the MySQL Connection.
    /// </summary>
    /// <remarks>
    /// This class can open connection, close connection, and get connection.
    /// </remarks>
    class DB
    {

        private MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=admin;database=hubit");


        /// <summary>
        /// Opens connection to the server.
        /// </summary>
        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        /// <summary>
        /// Closes connection to the server.
        /// </summary>
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        /// <summary>
        /// Gets the connection status of the server.
        /// </summary>
        /// <returns>
        /// The connection status of the server.
        /// </returns>
        public MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
