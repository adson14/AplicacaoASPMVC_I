using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AplicacaoASP.Startup))]
namespace AplicacaoASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
