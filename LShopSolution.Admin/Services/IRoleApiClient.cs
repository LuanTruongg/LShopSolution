using LShopSolution.ViewModels.Authen.Roles;
using LShopSolution.ViewModels.Common;

namespace LShopSolution.Admin.Services
{
    public interface IRoleApiClient
    {
        Task<ApiResult<List<RoleVM>>> GetAll();
    }
}
