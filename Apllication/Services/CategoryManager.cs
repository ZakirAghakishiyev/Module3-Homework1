using Application.DTO;
using Application.Repository;
using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services;

    public class CategoryManager
    {
        private readonly ICategoryRepository _repository;

        public CategoryManager(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public void AddCategory(CategoryCreateDTO category)
        {
            var newCategory = new Category { Name = category.Name};
            _repository.Add(newCategory);
        }

        public void DeleteCategory(int id)
        {
            _repository.Remove(id);
        }

        public void UpdateCategory(int id, Category category)
        {
            _repository.Update(id, category);
        }

        public List<CategoryDTO> GetCategorys(Expression<Func<Category, bool>>? predicate = null)
        {
        var CategoryDTOs = new List<CategoryDTO>();

            foreach (var item in _repository.GetAll(predicate))
            {
                CategoryDTOs.Add(new CategoryDTO
                {
                    Id=item.Id,
                    Name = item.Name,
                    Products=item.Products?.Select(x=>new ProductDTO { Id = x.Id, Name = x.Name }).ToList()
                });
            }
            return CategoryDTOs;
        }
    }


