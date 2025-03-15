using Application.Repository;
using Application.Services;
using Domain.Model;
using Infrastructure.EFCore;
using Infrastructure.Repository;
namespace Module3_Homework1;

internal class Program
{
    static void Main(string[] args)
    {
        var dbContext = new AppDBContext();
        var ProductRepo = new ProductRepository(dbContext);
        var ProductManager = new ProductManager(ProductRepo);

        var CategoryRepo = new CategoryRepository(dbContext);
        var CategoryManager = new CategoryManager(CategoryRepo);

        //ProductManager.AddProduct(new Application.DTO.ProductCreateDTO()
        //{
        //    Name = "Alma",
        //    CategoryId = 1
        //});

        //ProductManager.AddProduct(new Application.DTO.ProductCreateDTO()
        //{
        //    Name = "armud",
        //    CategoryId = 1
        //});
        //ProductManager.AddProduct(new Application.DTO.ProductCreateDTO()
        //{
        //    Name = "su",
        //    CategoryId = 2
        //});

        //ProductManager.AddProduct(new Application.DTO.ProductCreateDTO()
        //{
        //    Name = "kola",
        //    CategoryId = 2
        //});

        foreach (var item in CategoryManager.GetCategorys())
        {
            Console.WriteLine($"{item.Id}. {item.Name}");

            foreach (var product in item.Products)
            {
                Console.WriteLine($"{product.Id}. {product.Name}");
            }

        }
    }
}
