using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buildeeji.Startup))]
namespace Buildeeji
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
