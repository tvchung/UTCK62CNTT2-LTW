using Microsoft.AspNetCore.Mvc;
using TvcDay06Annotation.Models;

namespace TvcDay06Annotation.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserManual()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserManual(User user)
        {
            // Kiểm tra password cố độ dài tối thiểu 7 ký tự
            string password = user.Password;
            if (password.Length <7)
            {
                ViewBag.PasswordErr = "Mật khẩu có độ dài tối thiểu 7 ký tự";
                return View();
            }

            // email
            string email = user.Email;
            string regexPattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email,regexPattern))
            {
                ViewBag.EmailErr = "Email không đúng định dạng";
                return View();
            }

            return Content("Qua rồi, hahaa........");
        }


        public IActionResult UserAnnotation()
        {
            return View();
        }

    }
}
