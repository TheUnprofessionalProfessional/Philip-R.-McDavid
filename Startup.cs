using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Philip_R.McDavid.Startup))]
namespace Philip_R.McDavid
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
