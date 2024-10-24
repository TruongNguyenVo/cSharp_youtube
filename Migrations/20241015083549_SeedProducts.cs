using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
              table: "Product",
              columns: new[] { "Id", "Name", "Description", "Price" },
              values: new[]
              {
                new  { Id = 100, Name = "Sản phẩm A", Description = "Mô tả sản phẩm A", Price = 10000 }
              });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
