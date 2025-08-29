namespace TvcDay03View.Models
{
    public class Student
    {
        public int Id { get; set; }         // Mã sinh viên
        public string Name { get; set; }    // Tên sinh viên
        public int Age { get; set; }        // Tuổi
        public string Gender { get; set; }  // Giới tính ("Male", "Female", ...)
        public bool IsActive { get; set; }  // Trạng thái (true = đang học, false = nghỉ)
    }
}
