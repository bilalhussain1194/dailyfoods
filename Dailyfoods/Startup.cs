using Microsoft.Owin;
using Owin;
using System;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Dailyfoods.Models;
[assembly: OwinStartupAttribute(typeof(Dailyfoods.Startup))]
namespace Dailyfoods
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createuserandroles();
        }
        public void createuserandroles()
        {
            ApplicationDbContext db = new ApplicationDbContext();
            var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>);
            var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>)
            

        }
    }
}
