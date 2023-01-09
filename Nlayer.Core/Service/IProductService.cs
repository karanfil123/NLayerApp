using Nlayer.Core.Dtos.ProductDtos;
using Nlayer.Core.Dtos.ResponseDtos;
using Nlayer.Core.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Core.Service
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategoryAsync();
    }
}
