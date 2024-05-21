using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Party.Startup))]
namespace Party
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
