using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(vid3.Startup))]
namespace vid3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
