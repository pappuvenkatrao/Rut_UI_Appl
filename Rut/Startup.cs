using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rut.Startup))]
namespace Rut
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
