using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NSInmobiliaria.Startup))]
namespace NSInmobiliaria
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
