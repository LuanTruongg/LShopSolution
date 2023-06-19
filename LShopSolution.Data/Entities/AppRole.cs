using Microsoft.AspNetCore.Identity;

namespace LShopSolution.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
