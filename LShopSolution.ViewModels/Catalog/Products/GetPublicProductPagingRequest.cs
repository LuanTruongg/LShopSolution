using LShopSolution.Dtos;

namespace LShopSolution.ViewModels.Catalog.Products
{
    public class GetPublicProductPagingRequest :PagingRequestBase
    {
        //public string LanguageId { get; set; }
        public int? CategoryId { get; set; }
    }
}
