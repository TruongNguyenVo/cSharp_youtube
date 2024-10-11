using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Product
    {
        //public int Id { get; set; }
        //public string Name { get; set; }
        //public decimal Price { get; set; }
        //public string Description { get; set; }
        //public IFormFile ImagePath { get; set; }


        //[ForeignKey(nameof(Category.Id))]
        //public int CategoryId { get; set; }
        //public Category? Category { get; set; }

        //        public List<ProductImage>? ProductImages { get; set; } // 1 product chua nhieu image
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [NotMapped]
        public IFormFile? File { get; set; }
    }
}
