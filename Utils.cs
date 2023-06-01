using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;

class Utils {
    public static DBUser? GetUser(string username)
    {
        var connectionBuilder = new SqliteConnectionStringBuilder();
        connectionBuilder.DataSource = "database.db";

        using (var connection = new SqliteConnection(connectionBuilder.ConnectionString)) {
            connection.Open();
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM users WHERE username = $username";
            selectCmd.Parameters.AddWithValue("$username", username);

            using (SqliteDataReader reader = selectCmd.ExecuteReader()) {
                while (reader.Read())
                    return DBUser.FromReader(reader);
            }
        }
        return null;
    }

    public static void AddUser(string username, string password)
    {
        var connectionBuilder = new SqliteConnectionStringBuilder();
        connectionBuilder.DataSource = "database.db";

        using (var connection = new SqliteConnection(connectionBuilder.ConnectionString)) {
            connection.Open();
            SqliteCommand insertCmd = connection.CreateCommand();
            insertCmd.CommandText = "INSERT INTO users VALUES ($username, $password, $is_admin, $token)";
            insertCmd.Parameters.AddWithValue("$username", username);
            insertCmd.Parameters.AddWithValue("$password", Utils.GetMD5Hash(password));
            insertCmd.Parameters.AddWithValue("$is_admin", false);
            insertCmd.Parameters.AddWithValue("$token", Utils.GetMD5Hash(username + password + Utils.GetTimestampString()));
            insertCmd.ExecuteNonQuery();
        }
    }

    public static string GetMD5Hash(string password) {
        MD5 md5 = MD5.Create();
        byte[] hashBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(password));
        return Convert.ToHexString(hashBytes);
    }

    public static string GetTimestampString() {
        return new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
    }
}