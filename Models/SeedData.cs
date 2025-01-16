using cashRegister.Repositories;

namespace cashRegister.Models;

public class SeedData
{
    public static async Task Initialize(IServiceProvider serviceProvider, IProductRepository productRepository, ICategoryRepository categoryRepository)
    {
        // Populate Category table if empty
        if (await categoryRepository.Count() == 0)
        {
            await categoryRepository.Add(new Category { Name = "Alimentaire" });    // CategoryId: 1
            await categoryRepository.Add(new Category { Name = "Electronique" }); // CategoryId: 2
            await categoryRepository.Add(new Category { Name = "Hygiène" });      // CategoryId: 3
            await categoryRepository.Add(new Category { Name = "Mobilier" });     // CategoryId: 4
        }

        // Populate Product table if empty
        if (await productRepository.Count() == 0)
        {
            await productRepository.Add(new Product
            {
                Name = "Oreo",
                Description = "Doux biscuit croquant au chocolat et à la vanille.",
                Price = 2.29,
                Quantity = 1000,
                CategoryId = 1
            });

            await productRepository.Add(new Product
            {
                Name = "iPhone 14",
                Description = "Smartphone de dernière génération d'Apple avec écran OLED.",
                Price = 999.99,
                Quantity = 50,
                CategoryId = 2
            });

            await productRepository.Add(new Product
            {
                Name = "Shampooing Dove",
                Description = "Shampooing hydratant pour cheveux normaux.",
                Price = 4.49,
                Quantity = 500,
                CategoryId = 3
            });

            await productRepository.Add(new Product
            {
                Name = "Table en bois",
                Description = "Table à manger robuste en chêne massif.",
                Price = 249.99,
                Quantity = 10,
                CategoryId = 4
            });

            await productRepository.Add(new Product
            {
                Name = "Nutella",
                Description = "Pâte à tartiner aux noisettes et cacao.",
                Price = 3.99,
                Quantity = 800,
                CategoryId = 1
            });

            await productRepository.Add(new Product
            {
                Name = "TV Samsung 4K",
                Description = "Télévision 4K Ultra HD avec écran 55 pouces.",
                Price = 799.99,
                Quantity = 25,
                CategoryId = 2
            });

            await productRepository.Add(new Product
            {
                Name = "Savon liquide",
                Description = "Savon liquide antibactérien pour les mains.",
                Price = 2.49,
                Quantity = 400,
                CategoryId = 3
            });

            await productRepository.Add(new Product
            {
                Name = "Chaise ergonomique",
                Description = "Chaise de bureau confortable avec support lombaire.",
                Price = 129.99,
                Quantity = 15,
                CategoryId = 4
            });

            await productRepository.Add(new Product
            {
                Name = "Céréales Kellogg's",
                Description = "Céréales au blé complet pour un petit déjeuner équilibré.",
                Price = 3.49,
                Quantity = 700,
                CategoryId = 1
            });

            await productRepository.Add(new Product
            {
                Name = "Casque Bose QC45",
                Description = "Casque audio sans fil avec réduction active du bruit.",
                Price = 349.99,
                Quantity = 20,
                CategoryId = 2
            });
        }
    }
}
