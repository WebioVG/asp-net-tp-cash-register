using cashRegister.Models;

namespace cashRegister.Repositories;

public interface ICategoryInterface
{
    public Task<int> Count();
    public Task<Category> GetById(int categoryId);
    public Task<List<Category>> GetAll();
    public Task<Category> Add(Category category);
}