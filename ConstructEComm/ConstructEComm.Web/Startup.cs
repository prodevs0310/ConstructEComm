using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConstructEComm.Web.Startup))]
namespace ConstructEComm.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
