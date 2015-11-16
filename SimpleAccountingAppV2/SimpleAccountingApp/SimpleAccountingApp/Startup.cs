using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SimpleAccountingApp.Startup))]
namespace SimpleAccountingApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
