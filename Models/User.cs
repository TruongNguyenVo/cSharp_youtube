using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [DefaultValue("Nam")]
        [RegularExpression(@"^(Nam|Nữ|Không xác định)$",ErrorMessage = "Chỉ nhận các giá trị Nam, Nữ, Hoặc Không xác định.")]
        public string Gender { get; set; }

    }
}
