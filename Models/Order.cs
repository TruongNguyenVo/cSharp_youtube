using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using WebApplication1.Helpers;

namespace WebApplication1.Models
{
    public class Order
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [DataType(DataType.Date)]
        [DateNotAfter(nameof(OrderDate),ErrorMessage ="Ngay nhan khong duoc nho hon ngay dat hang")]
        public DateTime ReceiveDate { get; set; }
    }
}
