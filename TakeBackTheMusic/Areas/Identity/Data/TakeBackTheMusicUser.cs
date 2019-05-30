using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TakeBackTheMusic.Areas.Identity.Data
{
    // For reference to this namespace reason for existence, refer to https://docs.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-2.1

    // Add profile data for application users by adding properties to the TakeBackTheMusicUser class

    public class TakeBackTheMusicUser : IdentityUser
    {
        public string DisplayName { get; set; }
        [PersonalData]
        public DateTime DOB { get; set; }
    }
}
 