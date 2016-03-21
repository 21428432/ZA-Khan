using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZA_Khan.Startup))]
namespace ZA_Khan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
