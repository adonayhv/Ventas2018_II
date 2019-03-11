using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ventas2018_II.Backend.Startup))]
namespace Ventas2018_II.Backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
