﻿using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(FenzyCars.Web.Areas.Identity.IdentityHostingStartup))]

namespace FenzyCars.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}