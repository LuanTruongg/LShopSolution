using LShopSolution.Dtos;
using LShopSolution.ViewModels.Catalog.Product;
using LShopSolution.ViewModels.Catalog.ProductImages;
using LShopSolution.ViewModels.Catalog.Products;
using LShopSolution.ViewModels.Catalog.Products.Manage;
using LShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace LShopSolution.Catalog.Products
{
    public interface IProductService
    {
        Task<PagedResult<ProductViewModel>> GetAllByCategoryId(string languageId, GetPublicProductPagingRequest request);
        Task<int> Create(ProductCreateRequest request);

        Task<int> Update(ProductUpdateRequest request);
        Task<bool> UpdatePrice(int productId, decimal newPrice);
        Task<bool> UpdateStock(int productId, int addedQuantity);
        Task AddViewCount(int productId);
        Task<int> Delete(int productId);
        Task<ProductViewModel> GetById(int productId, string languageId);

        Task<PagedResult<ProductViewModel>> GetAllPaging(GetManageProductPagingRequest request);

        Task<int> AddImage(int productId, ProductImageCreateRequest request);

        Task<int> RemoveImage(int imageId);

        Task<int> UpdateImage(int imageId, ProductImageUpdateRequest request);
        
        Task<List<ProductImageViewModel>> GetListImages(int productId);

        Task<ProductImageViewModel> GetImageById(int imageId);
    }
}