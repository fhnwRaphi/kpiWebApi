using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kpiWebGui.Startup))]
namespace kpiWebGui
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
