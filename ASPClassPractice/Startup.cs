using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ASPClassPractice.Startup))]
namespace ASPClassPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
