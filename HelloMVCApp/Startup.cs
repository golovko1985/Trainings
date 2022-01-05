using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloMVCApp.Startup))]
namespace HelloMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
