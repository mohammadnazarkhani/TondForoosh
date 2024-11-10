﻿using TondForoosh.Api.Common;
using TondForoosh.Api.Dtos.Product;

namespace TondForoosh.Api.Entities
{
    public class Product : IUpdatable<UpdateProductDto>
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
        public List<SellerProduct> SellerProducts { get; set; } = new List<SellerProduct>();

        // Implementation of UpdateEntity method for Product
        public void UpdateEntity(UpdateProductDto dto)
        {
            Name = dto.Name;
            Price = dto.Price;
            ProductCategoryId = dto.ProductCategoryId;
        }
    }
}
