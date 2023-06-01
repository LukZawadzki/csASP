using Microsoft.Data.Sqlite;

class DBUser {
    public string username;
    public string passwordHash;
    public bool isAdmin;
    public string token;

    DBUser(string username, string passwordHash, bool isAdmin, string token) {
        this.username = username;
        this.passwordHash = passwordHash;
        this.isAdmin = isAdmin;
        this.token = token;
    }

    public static DBUser FromReader(SqliteDataReader reader) {
        return new DBUser(reader.GetString(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3));
    }
}