using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace SkillCenter.Data.Login
{
    public class LoginContext : IdentityDbContext<IdentityUser>
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
        }

        // Additional DbSets related to login, if needed
    }
}
