using LShopSolution.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace LShopSolution.Admin.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}
