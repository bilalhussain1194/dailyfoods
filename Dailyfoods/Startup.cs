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

            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
            var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));



     
            if(!RoleManager.RoleExists("superadmin"))
            {
               
                var superuserdetails = new ApplicationUser();
                superuserdetails.UserName = "admin@dailyfoods.com.pk";
                superuserdetails.Email = "admin@dailyfoods.com.pk";
                superuserdetails.dateofbirth = Convert.ToDateTime("2/17/2018");
                superuserdetails.LockoutEnabled = false;
                var pwd = "Dailyfoods123@";
                
                var superuser = UserManager.Create(superuserdetails, pwd);
                if (superuser.Succeeded)

                {
                    var role = new IdentityRole("superadmin");
                    RoleManager.Create(role);


                    UserManager.AddToRole(superuserdetails.Id, "superadmin");
                }
            }

            

           

          
        //var rolemanager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>);
        //var usermanager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>)


      }
    }
}
