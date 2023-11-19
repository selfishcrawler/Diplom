using Microsoft.AspNetCore.Identity;

namespace WebService.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser<Guid>
    {
    }

}
