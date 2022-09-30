using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using task_1.Areas.Identity.Data;
using task_1.Data;

[assembly: HostingStartup(typeof(task_1.Areas.Identity.IdentityHostingStartup))]
namespace task_1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<task_1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("task_1ContextConnection")));

                services.AddDefaultIdentity<task_1User>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<task_1Context>();
            });
        }
    }
}