using LShopSolution.ViewModels.Common;

namespace LShopSolution.Dtos
{
    public class PagingRequestBase : RequestBase
    {
        public int PageIndex { get; set; }
        public int PageSize { get; set; }
    }
}
