using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace LShopSolution.EF
{
    public class LShopDbContextFactory : IDesignTimeDbContextFactory<LShopDbContext>
    {
        public LShopDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("LShopSolutionDb");

            var optionsBuilder = new DbContextOptionsBuilder<LShopDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new LShopDbContext(optionsBuilder.Options);
        }
    }
}
