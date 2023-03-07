using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.Service;

namespace Nlayer.API.Controllers
{
    public class CategoriesController : CustomBaseController
    {
        readonly private ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("[action]/{categoryId}")]
        public async Task<IActionResult> GetCategoryByIdWithProducts(int categoryId)
        {
            return CreateActionResult(await _categoryService.GetCategoryByIdWithProductsAsync(categoryId));
        }
    }
}
