using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BU.Startup))]
namespace BU
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
