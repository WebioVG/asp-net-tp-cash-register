using cashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace cashRegister.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<int> Count()
    {
        return await _context.Products.CountAsync();
    }
    
    public Task<Product> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<Product> Add(Product product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }
}