using Microsoft.AspNetCore.Mvc;
using TvcDay03View.Models;

namespace TvcDay03View.Controllers
{
    public class PassDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewDataDemo()
        {
            ViewData["name"] = "Chung Trịnhh";
            ViewData["time"] =  DateTime.Now;

            // Object
            var student = new Student
            {
                Id = 1,
                Name = "Mù Căng Chải",
                Age = 20,
                Gender = "Male",
                IsActive = true
            };
            ViewData["student"]= student;

            // List Object
            // Tạo danh sách 5 Student
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyễn Văn A", Age = 20, Gender = "Male",   IsActive = true  },
                new Student { Id = 2, Name = "Trần Thị B",   Age = 21, Gender = "Female", IsActive = true  },
                new Student { Id = 3, Name = "Lê Văn C",     Age = 19, Gender = "Male",   IsActive = false },
                new Student { Id = 4, Name = "Phạm Thị D",   Age = 22, Gender = "Female", IsActive = true  },
                new Student { Id = 5, Name = "Hoàng Văn E",  Age = 23, Gender = "Male",   IsActive = false }
            };
            ViewData["students"] = students;

            return View();
        }
        public IActionResult ViewBagDemo()
        {
            ViewBag.name = "Chung Trịnhh";
            ViewBag.time = DateTime.Now;

            // Object
            var student = new Student
            {
                Id = 1,
                Name = "Mù Căng Chải",
                Age = 20,
                Gender = "Male",
                IsActive = true
            };
            ViewBag.student = student;

            // List Object
            // Tạo danh sách 5 Student
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyễn Văn A", Age = 20, Gender = "Male",   IsActive = true  },
                new Student { Id = 2, Name = "Trần Thị B",   Age = 21, Gender = "Female", IsActive = true  },
                new Student { Id = 3, Name = "Lê Văn C",     Age = 19, Gender = "Male",   IsActive = false },
                new Student { Id = 4, Name = "Phạm Thị D",   Age = 22, Gender = "Female", IsActive = true  },
                new Student { Id = 5, Name = "Hoàng Văn E",  Age = 23, Gender = "Male",   IsActive = false }
            };
            ViewBag.students = students;

            return View();
        }
    }
}
