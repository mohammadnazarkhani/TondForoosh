﻿using TondForoosh.Api.Dtos.Category;

namespace TondForoosh.Api.Entities
{
    public class ProductCategory 
    {
        public int Id { get; set; }
        public required string Title { get; set; }

        // Navigation property for products
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
