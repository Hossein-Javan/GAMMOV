using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMMOV.CoreLayer.DTOs.Category;
using GAMMOV.CoreLayer.Utilities;

namespace GAMMOV.CoreLayer.Services.Category
{
    public interface ICategoryService
    {
        OperationResult CreateCategory(CreateCategoryDto command);
        OperationResult EditCategory(EditCategoryDto  command);
        List<CategoryDto> GetCategories();
        CategoryDto GetCategoryBy(int id);
        CategoryDto GetCategoryBy(string slug);
    }
}
