using LShopSolution.ViewModels.Authen.Roles;

namespace LShopSolution.Authen.Roles
{
    public interface IRoleService
    {
        Task<List<RoleVM>> GetAll();
    }
}
