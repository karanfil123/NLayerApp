using AutoMapper;
using Nlayer.Core.Dtos.ProductDtos;
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
    public class ProductService : Service<Product>, IProductService
    {
        readonly private IProductRepository _productRepository;
        readonly private IMapper _mapper;
        public ProductService(IProductRepository productRepository, IMapper mapper, IGenericRepository<Product> repository, IUnitofwork unitofwork) : base(repository, unitofwork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public async Task<CustomResponseDto<List<ProductsWithCategoryDto>>> GetProductsWithCategoryAsync()
        {
            var product = await _productRepository.GetProductWithCategory();
            var productDto=_mapper.Map<List<ProductsWithCategoryDto>>(product);
            return CustomResponseDto<List<ProductsWithCategoryDto>>.Success(productDto, 200);
        }
    }
}
