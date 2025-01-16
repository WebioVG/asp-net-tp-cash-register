namespace cashRegister.Models;

public class ProductEditViewModel
{
    public Models.Product Product { get; set; }
    public IEnumerable<Category> Categories { get; set; }
}
