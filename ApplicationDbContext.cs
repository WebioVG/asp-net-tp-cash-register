using cashRegister.Models;
using Microsoft.EntityFrameworkCore;

namespace cashRegister;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
}