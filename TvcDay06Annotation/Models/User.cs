using System.ComponentModel.DataAnnotations;

namespace TvcDay06Annotation.Models
{
    public class User
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Bạn chưa nhập Tài khoản")]
        //[StringLength(50,MinimumLength = 5, ErrorMessage ="Tài khoản tối thiểu 5 ký tự, tối đa 50 ký tự")]
        [RegularExpression(@"[A-Z]{5,50}",ErrorMessage = "Tài khoản là ký tự hoa, tối thiểu 5 ký tự, tối đa 50 ký tự")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập mật khẩu")]
        //[StringLength(50,MinimumLength =6,"Mật khẩu tối thiểu 6 ký tự")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^A-Za-z0-9]).{6,50}$",
            ErrorMessage = "Mật khẩu phải có ít nhất 1 chữ hoa, 1 chữ thường, 1 số và 1 ký tự đặc biệt")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập lại mật khẩu")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập tuổi")]
        [Range(18,60,ErrorMessage ="Tuổi từ 18 đến 60")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Bạn chưa nhập Email")]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[A-Za-z]{2,}$",
                                ErrorMessage = "Địa chỉ Email không hợp lệ")]
        public string Email { get; set; }

    }
}
