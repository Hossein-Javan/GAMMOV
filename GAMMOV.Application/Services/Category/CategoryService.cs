using GAMMOV.CoreLayer.DTOs.Category;
using GAMMOV.CoreLayer.Mappers;
using GAMMOV.CoreLayer.Utilities;
using GAMMOV.DataLayer.Context;
using GAMMOV.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace GAMMOV.CoreLayer.Services.Category;

public class CategoryService : ICategoryService
{
    private readonly GAMMOVContext _context;

    public CategoryService(GAMMOVContext context)
    {
        _context = context;
    }

    public OperationResult CreateCategory(CreateCategoryDto command)
    {
        var category = new DataLayer.Entities.Category
        {
            Icon = command.Icon,
            ParentId = command.ParentId,
            SeoData = new SeoData()
            {
                OgUrl = command.SeoData.OgUrl,
                MetaDescription = command.SeoData.MetaDescription,
                MetaTitle = command.SeoData.MetaTitle,
                OgImg = command.SeoData.OgImg
            },
            Slug = command.Slug,
            Title = command.Title
        };
        try
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return OperationResult.Success();
        }
        catch (Exception message)
        {
            var e = message.ToString();
            return OperationResult.Error(e);
        }
    }

    public OperationResult EditCategory(EditCategoryDto command)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Id == command.Id);
        if (category == null) 
            return OperationResult.NotFound();
        category.Title = command.Title;
        category.Slug = command.Slug;
        category.Icon = command.Icon;
        category.ParentId = command.ParentId;
        category.SeoData.MetaTitle = command.SeoData.MetaTitle;
        category.SeoData.MetaDescription = command.SeoData.MetaDescription;
        category.SeoData.OgImg = command.SeoData.OgImg;
        category.SeoData.OgUrl = command.SeoData.OgUrl;

        try
        {
            _context.SaveChanges();
            return OperationResult.Success();
        }
        catch (Exception message)
        {
            throw new ApplicationException("Unable to create a category", message);
        }
    }

    public List<CategoryDto> GetCategories()
    {
        var categoriesWithSeoData = _context.Categories
            .Include(c => c.SeoData)
            .ToList();  

        return categoriesWithSeoData.Select(CategoryMapper.Map).ToList();

    }

    public CategoryDto GetCategoryBy(int id)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Id == id);
        return category == null ? null : CategoryMapper.Map(category);
    }

    public CategoryDto GetCategoryBy(string slug)
    {
        var category = _context.Categories.FirstOrDefault(c => c.Slug == slug);
        return category == null ? null : CategoryMapper.Map(category);
    }
}