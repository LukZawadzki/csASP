using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csASP.Models;

namespace csASP.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;

    public LoginController(ILogger<LoginController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public bool LoginUser(string username, string password)
    {
        DBUser? user = Utils.GetUser(username);
        if (user == null)
            return false;

        bool result = Utils.GetMD5Hash(password) == user.passwordHash;
        if (result) {
            HttpContext.Session.SetString("LOGGED_USER_USERNAME", user.username);
            HttpContext.Session.SetString("LOGGED_USER_IS_ADMIN", user.isAdmin.ToString());
            HttpContext.Session.SetString("LOGGED_USER_TOKEN", user.token);
        }
        
        return result;
    }

    [HttpPost] 
    public IActionResult HandleLoginForm(IFormCollection form)
    {
        string username = form["username"].ToString();
        string password = form["password"].ToString();

        if (LoginUser(username, password))
            HttpContext.Session.SetString("USER_STATUS", "LOGGED_IN");
        else
            HttpContext.Session.SetString("USER_STATUS", "INVALID_CREDENTIALS");

        return RedirectToAction(actionName: "Index", controllerName: "Login");
    }

    [HttpPost] 
    public IActionResult HandleLogoutForm(IFormCollection form)
    {
        HttpContext.Session.SetString("USER_STATUS", "LOGGED_OUT");

        return RedirectToAction(actionName: "Index", controllerName: "Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
