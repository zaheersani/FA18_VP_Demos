using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppPart_I.Startup))]
namespace WebAppPart_I
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
