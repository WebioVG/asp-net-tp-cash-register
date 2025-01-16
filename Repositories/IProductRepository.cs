using cashRegister.Models;

namespace cashRegister.Repositories;

public interface IProductRepository
{
    public Task<int> Count();
    public Task<Product?> GetById(int id);
    public Task<List<Product?>> GetAll();
    public Task<Product?> Add(Product? product);
    public Task<Product?> Update(Product? product);
}