using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class Users : IdentityUser
    {
        public string FullName { get; set; }
    }
}
