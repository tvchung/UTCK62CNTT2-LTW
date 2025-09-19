using Microsoft.AspNetCore.Mvc;
using TvcDay05MModel.Models;

namespace TvcDay05MModel.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult User() 
        {
            var objUser = new User();
            objUser.Id = 101;
            objUser.Name= "Chung Trịnh";
            objUser.Address="Tòa viện công nghệ, số 25 Vũ Ngọc Phan";
            objUser.Email = "chungtrinhj@gmail.com";

            ViewBag.user = objUser;

            return View(); 
        }

        public IActionResult ListUser()
        {
            List<User> users = new List<User>
            {
                new User { Id = 1, Name = "Trịnh Văn Chung", Address = "Hà Nội",       Email = "chungtrinhj@gmail.com" },
                new User { Id = 2, Name = "Nguyễn Thị Lan",   Address = "Hải Phòng",   Email = "lan@example.com" },
                new User { Id = 3, Name = "Lê Văn Minh",      Address = "Đà Nẵng",     Email = "minh@example.com" },
                new User { Id = 4, Name = "Phạm Thị Hồng",    Address = "Hồ Chí Minh", Email = "hong@example.com" },
                new User { Id = 5, Name = "Hoàng Anh Tuấn",   Address = "Cần Thơ",     Email = "tuan@example.com" }
            };

            //ViewBag.users = users;

            return View(users);
        }

    }
}
