using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using WebExamenFinal.Models;
[assembly: OwinStartupAttribute(typeof(WebExamenFinal.Startup))]
namespace WebExamenFinal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            CreateUserAndRole();
            ConfigureAuth(app);
        }

        internal void CreateUserAndRole()
        {
            using (var context = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
                var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                // In Startup iam creating first Admin Role and creating a default Admin User    
                if (!roleManager.RoleExists("Admin"))
                {

                    // first we create Admin rool   
                    var role = new IdentityRole();
                    role.Name = "Admin";
                    roleManager.Create(role);

                    //Here we create a Admin super user who will maintain the website                  

                    var user = new ApplicationUser
                    {
                        UserName = "dluna@gmail.com",
                        Email = "dluna@gmail.com"
                    };

                    string userPassword = "Sistemas2110";

                    var userCreation = userManager.Create(user, userPassword);

                    //Add default User to Role Admin   
                    if (userCreation.Succeeded)
                        userManager.AddToRole(user.Id, "Admin");
                }

                // creating Creating Manager role    
                if (!roleManager.RoleExists("Manager"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Manager"
                    };
                    roleManager.Create(role);

                }

                // creating Creating Employee role    
                if (!roleManager.RoleExists("Employee"))
                {
                    var role = new IdentityRole
                    {
                        Name = "Employee"
                    };
                    roleManager.Create(role);

                }
            }
        }
    }
}
