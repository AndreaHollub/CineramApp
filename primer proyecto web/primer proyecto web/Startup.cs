using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(primer_proyecto_web.Startup))]
namespace primer_proyecto_web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
