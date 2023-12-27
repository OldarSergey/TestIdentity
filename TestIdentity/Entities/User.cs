using Microsoft.AspNetCore.Identity;

namespace TestIdentity.Entities
{
    public class User : IdentityUser<int>
    {
        public bool IsDeleted { get; set; }


    }
}
