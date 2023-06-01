using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csASP.Models;

namespace csASP.Controllers;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;

    public RegisterController(ILogger<RegisterController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost] 
    public IActionResult HandleRegisterForm(IFormCollection form)
    {
        string username = form["username"].ToString();
        string password = form["password"].ToString();
        string password_confirm = form["password_confirm"].ToString();

        if (password != password_confirm) {
            HttpContext.Session.SetString("USER_STATUS", "PASSWORD_MISMATCH");
            return RedirectToAction(actionName: "Index", controllerName: "Register");
        }

        if (Utils.GetUser(username) != null) {
            HttpContext.Session.SetString("USER_STATUS", "USERNAME_EXISTS");
            return RedirectToAction(actionName: "Index", controllerName: "Register");
        }

        Utils.AddUser(username, password);
        
        HttpContext.Session.SetString("USER_STATUS", "REGISTERED");

        return RedirectToAction(actionName: "Index", controllerName: "Login");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
