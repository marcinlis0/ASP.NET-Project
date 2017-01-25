using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetApp.Startup))]
namespace AspNetApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
