using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TvcDay08EF_CF.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        public string Image { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public DateTime CreateDatte { get; set; }

        public int CategoryId { get; set; }

        public Category category { get; set; }
    }
}
