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
    
    public async Task<Product?> GetById(int id)
    {
        return await _context.Products.FindAsync(id);
    }

    public async Task<List<Product?>> GetAll()
    {
        return await _context.Products.ToListAsync();
    }

    public async Task<Product?> Add(Product? product)
    {
        await _context.Products.AddAsync(product);
        await _context.SaveChangesAsync();
        return product;
    }

    public async Task<Product?> Update(Product? product)
    {
        if (product == null)
        {
            return null;
        }
        
        var productToUpdate = _context.Products.FindAsync(product.Id);

        _context.Entry(productToUpdate).CurrentValues.SetValues(product);
        await _context.SaveChangesAsync();
        
        return product;
    }
}