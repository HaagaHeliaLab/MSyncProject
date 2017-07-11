using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MSyncProject.MobileAppService.Startup))]

namespace MSyncProject.MobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}