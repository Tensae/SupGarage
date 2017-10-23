using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupGarage.Startup))]
namespace SupGarage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
