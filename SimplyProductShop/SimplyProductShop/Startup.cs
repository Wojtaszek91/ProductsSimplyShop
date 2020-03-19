using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimplyProductShop.Startup))]
namespace SimplyProductShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
