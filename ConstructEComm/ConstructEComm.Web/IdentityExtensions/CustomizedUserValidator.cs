using System.Threading.Tasks;
using ConstructEComm.Web.Models;
using Microsoft.AspNet.Identity;

namespace ConstructEComm.Web.IdentityExtensions
{
    public class CustomizedUserValidator : IIdentityValidator<ApplicationUser>
    {
        public Task<IdentityResult> ValidateAsync(ApplicationUser item)
        {
            var responseTask = Task.FromResult<IdentityResult>(IdentityResult.Success);
            return responseTask;
        }
    }
}