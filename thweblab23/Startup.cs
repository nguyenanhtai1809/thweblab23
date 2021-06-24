using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(thweblab23.Startup))]
namespace thweblab23
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
