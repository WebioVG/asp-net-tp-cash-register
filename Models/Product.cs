using System.ComponentModel.DataAnnotations;

namespace cashRegister.Models;

public class Product
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public double Price { get; set; }
    [Required]
    public int Quantity { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public string? Image { get; set; }
}