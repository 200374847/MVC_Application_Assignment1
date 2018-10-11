using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Mvc_Application.Startup))]
namespace Mvc_Application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
