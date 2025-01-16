using cashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace cashRegister.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly ApplicationDbContext _context;

    public CategoryRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Count()
    {
        return await _context.Categories.CountAsync();
    }
    
    public async Task<Category?> GetById(int categoryId)
    {
        return await _context.Categories.FirstOrDefaultAsync(x => x.Id == categoryId);
    }

    public async Task<List<Category?>> GetAll()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category?> Add(Category? category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }
}