using ConstructEComm.Web.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ConstructEComm.Web.IdentityExtensions
{
    public class CustomizedAppUserManager : UserManager<ApplicationUser>
    {
        public CustomizedAppUserManager()
            : base(new UserStore<ApplicationUser>(new ApplicationDbContext()))
        {
            this.UserValidator = new CustomizedUserValidator();
        }
    }
}