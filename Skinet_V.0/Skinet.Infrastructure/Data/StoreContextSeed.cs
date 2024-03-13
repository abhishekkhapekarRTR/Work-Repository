
using Skinet.Core.Entities;
using System.Text.Json;

namespace Skinet.Infrastructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            //Seeding brands data
            if(!context.ProductBrand.Any())
            {
                var brandsData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrand.AddRange(brands);
            }

            //seeding types data
            if (!context.ProductType.Any())
            {
                var typesData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                context.ProductType.AddRange(types);
            }

            //seeding products data
            if (!context.Products.Any())
            {
                var productsData = File.ReadAllText("../Skinet.Infrastructure/Data/SeedData/products.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
            }

            if (context.ChangeTracker.HasChanges())
            {
                await context.SaveChangesAsync();
            }
        }
    }
}
