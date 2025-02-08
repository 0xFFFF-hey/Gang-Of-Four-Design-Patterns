using Microsoft.Data.SqlClient;

namespace DesignPatterns.Creational.Singleton.DataBaseConnectionManager
{
    public class DbManager
    {
        // The lambda function is important to specify how the object will be constructed
        private static readonly Lazy<DbManager> _instance = new Lazy<DbManager>(() => new DbManager());
        private SqlConnection? _sqlConnection;
        private readonly string _connectionString = "MyConnectionString";

        private DbManager()
        {
            Console.WriteLine("[DB Manager] Initializing database connection...");
            _sqlConnection = new SqlConnection(_connectionString);
        }

        public static DbManager Instance => _instance.Value;

        public void OpenConnection()
        {
            if (_sqlConnection?.State == System.Data.ConnectionState.Closed)
            {
                _sqlConnection.Open();
                Console.WriteLine("[DB Manager] Connection opened.");
            }
        }

        public void ExecuteQuery(string query)
        {
            Console.WriteLine($"[Thread {Thread.CurrentThread.ManagedThreadId}] Executing query: {query}");
            Thread.Sleep(1000); // Simulate query execution time
        }

        public void CloseConnection()
        {
            if (_sqlConnection?.State == System.Data.ConnectionState.Open)
            {
                _sqlConnection?.Close();
                Console.WriteLine("[DB Manager] Connection closed.");
            }
        }
    }
}
