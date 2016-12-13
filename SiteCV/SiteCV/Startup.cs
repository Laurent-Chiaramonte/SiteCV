using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteCV.Startup))]
namespace SiteCV
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
