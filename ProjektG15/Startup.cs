using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjektG15.Startup))]
namespace ProjektG15
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
