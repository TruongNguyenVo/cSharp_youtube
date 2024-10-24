using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Newtonsoft.Json;
using WebApplication1.Models;

public partial class SeedProducts : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {

        migrationBuilder.InsertData(
            table: "Product",
            columns: new[] { "Name","Description", "Price" },
            values: new[]
            {
                new { Id = 1, Name = "Sản phẩm A",Description = "", Price = 10000 },
                new { Id = 2, Name = "Sản phẩm B",Description = "", Price = 20000 }
            });
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        
    }
}