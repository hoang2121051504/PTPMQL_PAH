using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}