using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SwarmTests.Startup))]
namespace SwarmTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
