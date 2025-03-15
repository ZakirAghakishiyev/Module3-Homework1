using Application.DTO;
using Application.Repository;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductManager
    {
        private readonly IProductRepository _repository;

        public ProductManager(IProductRepository repository)
        {
            _repository = repository;
        }

        public void AddProduct(ProductCreateDTO product)
        {
            var newProduct = new Product { Name=product.Name, CategoryId=product.CategoryId};
            _repository.Add(newProduct);
        }

        public void DeleteProduct(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateProduct(int id,Product product)
        {
            _repository.Update(id,product);
        }

        public List<ProductDTO> GetProducts(Expression<Func<Product, bool>>? predicate = null)
        {
            var ProductDTOs = new List<ProductDTO>();

            foreach (var item in _repository.GetAll(predicate))
            {
                ProductDTOs.Add(new ProductDTO
                {
                    Name = item.Name,
                    CategoryId = item.CategoryId,
                });
            }
            return ProductDTOs;
        }

    }

}
