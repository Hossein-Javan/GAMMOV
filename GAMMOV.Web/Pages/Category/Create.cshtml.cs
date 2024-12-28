using GAMMOV.CoreLayer.DTOs.Category;
using GAMMOV.CoreLayer.DTOs.SeoData;
using GAMMOV.CoreLayer.Services.Category;
using GAMMOV.CoreLayer.Utilities;
using GAMMOV.DataLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace GAMMOV.Web.Pages.Category
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ICategoryService _categoryService;
        public CreateModel(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public int? ParentId { get; set; }
        [Required(ErrorMessage = "نام دسته بندی الزامی است")]
        public string Title { get; set; }
        [Required(ErrorMessage = "پیوند دسته بندی الزامی است")]
        public string Slug { get; set; }
        [Required(ErrorMessage = "تصویر آیکون الزامی است")]
        public string Icon { get; set; }
        [Required(ErrorMessage = "مقادیر سئو الزامی است")]
        public SeoData SeoData { get; set; }
        public void OnGet()
        {
        }
        public CreateCategoryDto MapToDto()
        {
            return new CreateCategoryDto
            {
                Title = Title,
                Slug = Slug,
                Icon = Icon,
                ParentId = ParentId,
                SeoData = new CreateSeoDataDto
                {
                    MetaTitle = SeoData.MetaTitle,
                    MetaDescription = SeoData.MetaDescription,
                    OgImg = SeoData.OgImg,
                    OgUrl = SeoData.OgUrl
                }
            };
        }
        public IActionResult OnPost()
        {

            var result = _categoryService.CreateCategory(MapToDto());

            if (result.Status == OperationResultStatus.Success)
            {
                TempData["SuccessMessage"] = "Category successfully created.";
            }
            else
            {
                TempData["ErrorMessage"] = "There was an error creating the category.";

                ModelState.AddModelError("", result.Message);
            }

            return RedirectToPage("./Index");
        }

    }
}
