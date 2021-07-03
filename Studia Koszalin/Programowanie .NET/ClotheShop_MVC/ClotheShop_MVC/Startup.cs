using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClotheShop_MVC.Startup))]
namespace ClotheShop_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
