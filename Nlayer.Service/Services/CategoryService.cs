using AutoMapper;
using Nlayer.Core.Dtos.CategoryDtos;
using Nlayer.Core.Dtos.ResponseDtos;
using Nlayer.Core.Models.Entities;
using Nlayer.Core.Repository;
using Nlayer.Core.Service;
using Nlayer.Core.Unitofwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nlayer.Service.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        readonly private ICategoryRepository _categoryRepository;
        readonly private IMapper _mapper;
        public CategoryService(IGenericRepository<Category> repository, IUnitofwork unitofwork, ICategoryRepository categoryRepository, IMapper mapper) : base(repository, unitofwork)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }     

        public async Task<CustomResponseDto<CategoryWithProductsDto>> GetCategoryByIdWithProductsAsync(int categoryId)
        {
            var category = await _categoryRepository.GetCategoryByIdWithProductsAsync(categoryId);
            var categoryDto=_mapper.Map<CategoryWithProductsDto>(category);
            return CustomResponseDto<CategoryWithProductsDto>.Success(categoryDto,200);
        }
    }
}
