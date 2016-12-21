using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RpgApp.Startup))]
namespace RpgApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
