using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dailyfoods.Startup))]
namespace Dailyfoods
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
