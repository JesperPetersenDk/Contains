using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contains_Test.Startup))]
namespace Contains_Test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
