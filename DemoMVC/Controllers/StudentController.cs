using Microsoft.AspNetCore.Mvc;
namespace DeMoMVC.Controllers;

public class StudentController : Controller


{
    public IActionResult Index()
    {
        return View();
    }

}
