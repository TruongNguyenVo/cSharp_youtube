﻿using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
        [ForeignKey(nameof(Category.Id))]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
