using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly2nd.Startup))]
namespace Vidly2nd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
