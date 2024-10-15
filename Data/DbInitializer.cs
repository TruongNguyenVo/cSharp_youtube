using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DbInitializer
    {
        private readonly ApplicationDbContext _context;

        public DbInitializer(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Initialize()
        {
            // Kiểm tra xem cơ sở dữ liệu đã có dữ liệu chưa
            if (_context.Product.Any())
            {
                return;   // DB has been seeded
            }

            // Thêm dữ liệu mẫu
            _context.Product.AddRange(
                new Product { Name = "Product A", Description ="", Price = 10 },
                new Product { Name = "Product B", Description = "", Price = 20 },
                new Product { Name = "Product C", Description = "", Price = 20 },
                new Product { Name = "Product D", Description = "", Price = 20 },
                new Product { Name = "Product E", Description = "", Price = 20 }
            );
            _context.SaveChangesAsync();
        }
    }
}
