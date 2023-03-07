using Nlayer.Core.Dtos.CategoryDtos;
using Nlayer.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Repository
{
    public interface ICategoryRepository:IGenericRepository<Category>
    {
        Task<Category> GetCategoryByIdWithProductsAsync(int categoryId);
    }
}
