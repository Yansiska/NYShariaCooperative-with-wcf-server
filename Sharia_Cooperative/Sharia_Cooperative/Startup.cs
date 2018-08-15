using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Sharia_Cooperative.Startup))]
namespace Sharia_Cooperative
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
