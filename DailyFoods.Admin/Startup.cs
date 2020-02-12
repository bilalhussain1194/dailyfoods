using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DailyFoods.Admin.Startup))]
namespace DailyFoods.Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
