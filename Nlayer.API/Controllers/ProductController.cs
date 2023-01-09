using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Nlayer.Core.Dtos.ProductDtos;
using Nlayer.Core.Dtos.ResponseDtos;
using Nlayer.Core.Models.Entities;
using Nlayer.Core.Service;

namespace Nlayer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : CustomBaseController
    {
        readonly private IMapper _mapper;
        readonly private IProductService _productService;

        public ProductController(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }
        [HttpGet("[action]")]
        public async Task<IActionResult> GetProductsWithCategory()
        {
            return CreateActionResult(await _productService.GetProductsWithCategoryAsync());
        }
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var products = await _productService.GetAllAsync();
            var productDtos = _mapper.Map<List<ProductDto>>(products);
            return CreateActionResult(CustomResponseDto<List<ProductDto>>.Success(productDtos, 200));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var product = await _productService.GetByIdAsync(id);
            var productDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(productDto, 200));

        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductDto productDto)
        {
            var product = await _productService.AddAsync(_mapper.Map<Product>(productDto));
            var productsDto = _mapper.Map<ProductDto>(product);
            return CreateActionResult(CustomResponseDto<ProductDto>.Success(productDto, 201));
        }
        [HttpPut]
        public async Task<IActionResult> Update(ProductUpdateDto productDto)
        {
            await _productService.AddAsync(_mapper.Map<Product>(productDto));
            return CreateActionResult(CustomResponseDto<NoContent>.Success(204));
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            await _productService.RemoveAsync(await _productService.GetByIdAsync(id));
            return CreateActionResult(CustomResponseDto<NoContent>.Success(204));
        }
    }
}
