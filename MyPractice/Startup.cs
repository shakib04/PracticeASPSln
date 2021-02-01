using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyPractice.Startup))]
namespace MyPractice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
