using Domain.Model;
using Application.Repository;
using Infrastructure.EFCore;

namespace Infrastructure.Repository;

public class ProductRepository : EFCoreRepository<Product>, IProductRepository
{
    public ProductRepository(AppDBContext context) : base(context)
    {
    }
}
