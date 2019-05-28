using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TakeBackTheMusic.Areas.Identity.Data;
using TakeBackTheMusic.Models;

[assembly: HostingStartup(typeof(TakeBackTheMusic.Areas.Identity.IdentityHostingStartup))]
namespace TakeBackTheMusic.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDefaultIdentity<TakeBackTheMusicUser>()
                    .AddDefaultUI(UIFramework.Bootstrap4)
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<TakeBackTheMusicContext>()
                    ;       
            });
        }
    }
}