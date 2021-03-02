using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebApplication.Data.EF
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<WebApplicationDBContext>
    {
        public WebApplicationDBContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WebApplicationDb");

            var optionsBuilder = new DbContextOptionsBuilder<WebApplicationDBContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebApplicationDBContext(optionsBuilder.Options);
        }
    }
}
