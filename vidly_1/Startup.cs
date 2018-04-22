using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vidly_1.Startup))]
namespace vidly_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
