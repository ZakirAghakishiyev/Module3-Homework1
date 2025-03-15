using Domain.Model;
using Application.Repository;
using Infrastructure.EFCore;
using System;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repository;

public class CategoryRepository : EFCoreRepository<Category>, ICategoryRepository
{
    private readonly AppDBContext _context;

    public CategoryRepository(AppDBContext context) : base(context)
    { }
    public virtual List<Category> GetAll(Expression<Func<Category, bool>>? predicate = null)
    {
        var groups = _context.Categories
            .Include(x=>x.Products)
            .ToList(); 


        return groups;
    }
}

