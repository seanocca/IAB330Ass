using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(StandBandService.Startup))]

namespace StandBandService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}