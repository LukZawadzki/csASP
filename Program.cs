using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using csASP.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BazaContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BazaContext") ?? throw new InvalidOperationException("Connection string 'BazaContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromSeconds(600);
    options.Cookie.HttpOnly = true; //plik cookie jest niedostępny przez skrypt po stronie klienta
    options.Cookie.IsEssential = true; //pliki cookie sesji będą zapisywane dzięki czemu sesje będzie mogła być śledzona podczas nawigacji lub przeładowania strony
});

void InitDatabase() {
    var connectionBuilder = new SqliteConnectionStringBuilder();
    connectionBuilder.DataSource = "database.db";

    using (var connection = new SqliteConnection(connectionBuilder.ConnectionString)) {
        connection.Open();
        SqliteCommand createTableCmd = connection.CreateCommand();
        createTableCmd.CommandText = "CREATE TABLE IF NOT EXISTS users (username TEXT PRIMARY KEY, password TEXT NOT NULL, is_admin BOOLEAN NOT NULL, token TEXT NOT NULL)";
        createTableCmd.ExecuteNonQuery();

        SqliteCommand selectCmd = connection.CreateCommand();
        selectCmd.CommandText = "SELECT * FROM users";

        bool hasData = false;
        using (SqliteDataReader reader = selectCmd.ExecuteReader()) {
            while (reader.Read()) {
                hasData = true;
                break;
            }
        }
        
        if (hasData)
            return;
        
        SqliteCommand insertCmd = connection.CreateCommand();
        string adminToken = Utils.GetMD5Hash("adminadmin" + Utils.GetTimestampString());
        string userToken = Utils.GetMD5Hash("useruser" + Utils.GetTimestampString());
        insertCmd.CommandText = $"INSERT INTO users VALUES ('admin', '{Utils.GetMD5Hash("admin")}', TRUE, '{adminToken}'), ('user', '{Utils.GetMD5Hash("user")}', FALSE, '{userToken}')";
        insertCmd.ExecuteNonQuery();
    }
}

InitDatabase();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
