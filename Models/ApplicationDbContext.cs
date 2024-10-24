using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(){

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
       : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<WebApplication1.Models.Product> Product { get; set; } = default!;
        public DbSet<WebApplication1.Models.ProductImage> ProductImage { get; set; } = default!;
        public DbSet<WebApplication1.Models.User> User { get; set; } = default!;
        public DbSet<WebApplication1.Models.Order> Order { get; set; } = default!;
        public DbSet<WebApplication1.Models.Customer> Customers { get; set; } = default!;
        public DbSet<WebApplication1.Models.Manager> Managers { get; set; } = default!;



    }

}
