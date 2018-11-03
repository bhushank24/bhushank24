using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bhushank24.Startup))]
namespace bhushank24
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
