using GAMMOV.CoreLayer.DTOs.Category;
using GAMMOV.CoreLayer.Services.Category;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GAMMOV.Web.Pages.Category
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        private readonly ICategoryService _categoryService;

        public IndexModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public List<CategoryDto> Categories { get; set; }

        public void OnGet()
            {
                Categories = _categoryService.GetCategories();
            }

           
    }
}
