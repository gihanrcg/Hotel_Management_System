using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendanceRecorder
{
    public class DBConnect : IDisposable
    {
        public MySqlConnection con;
        private string server;
        private string database;
        private string username;
        private string password;
        private string port;
        private string sslMode;
        private static string connectionString;

        public DBConnect()
        {
            Initialize();
            
        }

        public void Initialize()
        {
            this.server = "localhost";
            this.database = "hotel";
            this.username = "root";
            this.password = "";
            this.port = "3306";
            this.sslMode = "none";

            //connectionString = "SERVER=" + this.server + ";" + "PORT: " + port + ";" + "DATABASE=" + this.database + ";" + "UID=" + this.username + ";" + "PASSWORD=" + this.password + ";";
            connectionString = "Server=" + server + ";Port=" + port + ";Database=" + database + ";Uid=" + username + ";Password=" + password + ";Sslmode=" + sslMode + ";";

            try
            {
                con = new MySqlConnection(connectionString);
                con.Open();
                //Console.WriteLine("Database connected");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                System.Windows.Forms.MessageBox.Show(e.Message, "Error connecting to Database");
            }
        }

        public void Dispose()
        {
            con.Close();
        }
    }
  
}
