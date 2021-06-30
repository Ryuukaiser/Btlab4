using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Btlab4.Startup))]
namespace Btlab4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
