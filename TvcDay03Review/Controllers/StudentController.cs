using Microsoft.AspNetCore.Mvc;

namespace TvcDay03Review.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
