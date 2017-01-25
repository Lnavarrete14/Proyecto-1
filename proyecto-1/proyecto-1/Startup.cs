using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(proyecto_1.Startup))]
namespace proyecto_1
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
