using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace ProfilePictureSample.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class ProfilePictureSampleDbContextFactory : IDesignTimeDbContextFactory<ProfilePictureSampleDbContext>
    {
        public ProfilePictureSampleDbContext CreateDbContext(string[] args)
        {
            ProfilePictureSampleEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ProfilePictureSampleDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new ProfilePictureSampleDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../ProfilePictureSample.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
