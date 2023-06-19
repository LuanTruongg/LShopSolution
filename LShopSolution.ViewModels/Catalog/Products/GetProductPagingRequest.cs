using LShopSolution.Dtos;
using System.Collections.Generic;

namespace LShopSolution.ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
