using LShopSolution.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LShopSolution.ViewModels.Catalog.Product
{
    public class GetManageProductPagingRequest : PagingRequestBase
    {
        public string keyword { get; set; }
        public List<int> CategoryIds { get; set; }
    }
}
