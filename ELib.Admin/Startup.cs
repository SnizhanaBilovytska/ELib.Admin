using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ELib.Admin.Startup))]
namespace ELib.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
