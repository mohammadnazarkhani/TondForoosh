using Core.Entities;

namespace Infrastructure.Data;

public interface ITondForooshRepository
{
    IQueryable<Product> Products { get; }
    Task<long> AddAsync(Product product);
    Task UpdateAsync(Product product);
    Task DeleteAsync(Product product);
}
