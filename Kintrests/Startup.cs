using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Kintrests.Startup))]
namespace Kintrests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
