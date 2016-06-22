using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CineramApp_0._1.Startup))]
namespace CineramApp_0._1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
