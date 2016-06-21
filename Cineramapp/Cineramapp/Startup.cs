using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cineramapp.Startup))]
namespace Cineramapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
