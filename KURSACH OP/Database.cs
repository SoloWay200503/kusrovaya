using System;
using System.Data.SQLite;
using System.Data;


namespace KURSACH_OP
{
    public class Database
    {
        public string dataSource;
        public Database(string dataSource)
        {
            this.dataSource = dataSource;
        }
        public bool InitializeDatabase()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "DROP TABLE IF EXISTS users;"
                    + "CREATE TABLE users("
                    + "id INTEGER PRIMARY KEY AUTOINCREMENT, "
                    + "login, "
                    + "password)";  
                    cmd.CommandText = sql_command;
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }

        public int UsersCount()
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "SELECT count(id) FROM users";
                    cmd.CommandText = sql_command;
                    return (int)cmd.ExecuteScalar();
                }
            }
            catch
            {
                return -1;
            }
            finally
            {
                conn.Dispose();
            }
            return -1;
        }

        public bool ValidUser(string login, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "SELECT COUNT(*) FROM users WHERE login=@login AND password=@password";
                    cmd.CommandText = sql_command;
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return false;
        }
        public bool AddUser(string login, string password)
        {
            SQLiteConnection conn = new SQLiteConnection(dataSource);
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    SQLiteCommand cmd = conn.CreateCommand();
                    string sql_command = "INSERT INTO users (login, password) VALUES (@login, @password)";
                    cmd.CommandText = sql_command;
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.ExecuteNonQuery();
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                conn.Dispose();
            }
            return true;
        }
    }

}
