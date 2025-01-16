using cashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace cashRegister.Repositories;

public class CategoryRepository : ICategoryInterface
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
    
    public Task<Category> GetById(int categoryId)
    {
        throw new NotImplementedException();
    }

    public Task<List<Category>> GetAll()
    {
        throw new NotImplementedException();
    }

    public async Task<Category> Add(Category category)
    {
        await _context.Categories.AddAsync(category);
        await _context.SaveChangesAsync();
        return category;
    }
}