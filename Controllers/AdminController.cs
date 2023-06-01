using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.Sqlite;
using csASP.Models;

namespace csASP.Controllers;

public class AdminController : Controller
{
    private readonly ILogger<AdminController> _logger;

    public AdminController(ILogger<AdminController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN" || HttpContext.Session.GetString("LOGGED_USER_IS_ADMIN") != "True")
            return RedirectToAction(actionName: "Index", controllerName: "Login");

        var connectionBuilder = new SqliteConnectionStringBuilder();
        connectionBuilder.DataSource = "database.db";

        List<DBUser> users = new List<DBUser>();
        using (var connection = new SqliteConnection(connectionBuilder.ConnectionString)) {
            connection.Open();
            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM users";

            using (SqliteDataReader reader = selectCmd.ExecuteReader()) {
                while (reader.Read())
                    users.Add(DBUser.FromReader(reader));
            }
        }
        ViewData["users"] = users;

        return View();
    }

    [HttpPost] 
    public IActionResult HandleAddUserForm(IFormCollection form)
    {
        if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN" || HttpContext.Session.GetString("LOGGED_USER_IS_ADMIN") != "True")
            return RedirectToAction(actionName: "Index", controllerName: "Login");

        string username = form["username"].ToString();
        string password = form["password"].ToString();

        if (Utils.GetUser(username) != null) {
            HttpContext.Session.SetString("ADD_USER_STATUS", "USERNAME_EXISTS");
            return RedirectToAction(actionName: "Index", controllerName: "Admin");
        }

        Utils.AddUser(username, password);
        
        HttpContext.Session.SetString("ADD_USER_STATUS", "SUCCESS");

        return RedirectToAction(actionName: "Index", controllerName: "Admin");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
