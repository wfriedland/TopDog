using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TopDog.Startup))]
namespace TopDog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
