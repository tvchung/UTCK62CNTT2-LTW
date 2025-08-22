using Microsoft.AspNetCore.Mvc;

namespace TvcDay02Controller.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

        public JsonResult data()
        {
            var data = new[]
            {
                new { Id = 1, Name = "Nguyễn Văn A", Age = 20, Email = "a@example.com" },
                new { Id = 2, Name = "Trần Thị B", Age = 21, Email = "b@example.com" },
                new { Id = 3, Name = "Lê Văn C", Age = 22, Email = "c@example.com" },
                new { Id = 4, Name = "Phạm Thị D", Age = 23, Email = "d@example.com" },
                new { Id = 5, Name = "Hoàng Văn E", Age = 24, Email = "e@example.com" }
            };

            return Json(data);
        }
    }
}
