using System;

namespace Core.Entities;

public class Product
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public string? ImageUrl { get; set; }

    // Relation with category
    public int CategoryId { get; set; }
    public Category? Category { get; set; }
}
