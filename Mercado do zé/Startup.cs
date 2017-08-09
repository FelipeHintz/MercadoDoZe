using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mercado_do_zé.Startup))]
namespace Mercado_do_zé
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
