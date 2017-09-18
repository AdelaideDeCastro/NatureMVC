using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NatureMVC.Startup))]
namespace NatureMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
