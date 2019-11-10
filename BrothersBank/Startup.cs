using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BrothersBank.Startup))]
namespace BrothersBank
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
