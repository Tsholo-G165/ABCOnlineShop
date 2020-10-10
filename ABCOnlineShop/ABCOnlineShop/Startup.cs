using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ABCOnlineShop.Startup))]
namespace ABCOnlineShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
