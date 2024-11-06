﻿namespace TondForoosh.Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required decimal Price { get; set; }

        // Foreign key for Product Category
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }

        // Navigation properties
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
