using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GAMMOV.CoreLayer.DTOs.Category;
using GAMMOV.CoreLayer.DTOs.SeoData;
using GAMMOV.DataLayer.Entities;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace GAMMOV.CoreLayer.Mappers
{
    public class CategoryMapper
    {
        public static CategoryDto Map(Category category)
        {
            var seoDataDto = new SeoDataDto(); // ایجاد نمونه خالی

            if (category.SeoData != null) // بررسی اینکه آیا SeoData null است
            {
                seoDataDto = new SeoDataDto()
                {
                    MetaTitle = category.SeoData.MetaTitle,
                    MetaDescription = category.SeoData.MetaDescription,
                    OgUrl = category.SeoData.OgUrl,
                    OgImg = category.SeoData.OgImg,
                    Id = category.SeoData.Id
                };
            }

            return new CategoryDto()
            {
                Title = category.Title,
                Slug = category.Slug,
                Icon = category.Icon,
                ParentId = category.ParentId,
                SeoData = seoDataDto, // استفاده از seoDataDto که ممکن است خالی باشد اگر SeoData null باشد
                Id = category.Id,
            };
        }
    }
}
