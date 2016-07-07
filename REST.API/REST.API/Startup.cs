using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(REST.API.Startup))]

namespace REST.API
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
