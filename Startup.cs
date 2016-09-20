using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sass.grid.web.Startup))]
namespace sass.grid.web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
