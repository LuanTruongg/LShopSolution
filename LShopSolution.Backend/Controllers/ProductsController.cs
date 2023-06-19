using LShopSolution.Catalog.Products;
using LShopSolution.Entities;
using LShopSolution.ViewModels.Catalog.ProductImages;
using LShopSolution.ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LShopSolution.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{languageId}")]
        public async Task<IActionResult> Get(string languageId, [FromQuery]GetPublicProductPagingRequest request)
        {
            var products = await _productService.GetAllByCategoryId(languageId, request);
            return Ok(products);
        }
        [HttpGet("{productId}/{languageId}")]
        public async Task<IActionResult> GetById(int productId,  string languageId)
        {
            var product = await _productService.GetById(productId, languageId);
            if (product == null)
            {
                return BadRequest("Cannot find product");
            }
            return Ok(product);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var productId = await _productService.Create(request);
            if (productId == 0)
                return BadRequest();
            var product = await _productService.GetById(productId, request.LanguageId);
            return Created(nameof(GetById), product);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromForm]ProductUpdateRequest request)
        {
            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpPatch("price/{productId}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int productId, decimal newPrice)
        {
            var affectedResult = await _productService.UpdatePrice(productId, newPrice);
            if (affectedResult)
                return Ok();
            return BadRequest();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var affectedResult = await _productService.Delete(productId);
            if (affectedResult == 0)
                return BadRequest();
            return Ok();
        }
        [HttpGet("{productId}/images/{imageId}")]
        public async Task<IActionResult> GetImageById(int productId, int imageId)
        {
            var image = await _productService.GetImageById(imageId);
            if (image == null)
            {
                return BadRequest("Cannot find image");
            }
            return Ok(image);
        }

        //images
        [HttpPost("{productId}/images")]
        public async Task<IActionResult> CreateImages(int productId, [FromForm]ProductImageCreateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var imageId = await _productService.AddImage(productId, request);
            if (imageId == 0)
                return BadRequest();
            var image = await _productService.GetImageById(imageId);
            return Created(nameof(GetImageById), image);
        }
        [HttpPut("{productId}/images/{imageId}")]
        public async Task<IActionResult> UpdateImages(int imageId, [FromForm] ProductImageUpdateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.UpdateImage(imageId, request);
            if (result == 0)
                return BadRequest();
            return Ok();
        }

        [HttpDelete("{productId}/images/{imageId}")]
        public async Task<IActionResult> DeleteImages(int imageId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var result = await _productService.RemoveImage(imageId);
            if (result == 0)
                return BadRequest();
            return Ok();
        }
    }
}
