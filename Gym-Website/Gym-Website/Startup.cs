using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gym_Website.Startup))]
namespace Gym_Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
