using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc5App_net461_cs_IIS_IndAuth_1.Startup))]
namespace Mvc5App_net461_cs_IIS_IndAuth_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
