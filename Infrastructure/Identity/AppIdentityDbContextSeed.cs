using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Core.Entities.Identity;
using System.Linq;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser

                {
                    DisplayName = "Bob",
                    Email = "gerard.com",
                    UserName = "Gerard",
                    Address = new Address
                    {
                        FirstName = "Gerard",
                        LastName = "Singian",
                        Street = "12 Street",
                        City = "New York",
                        State = "NY",
                        ZipCode = "88445"
                    }
                };
                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}