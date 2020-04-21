using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace WorkingAuthorization.Server.Identity
{
    public class ApplicationProfileService : IProfileService
    {
        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            context.IssuedClaims = new List<Claim>(new []{new Claim(ClaimTypes.Role, "Admin")});
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            context.IsActive = true;
            return Task.CompletedTask;
        }
    }
}