using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RepositoryPatternAndUnitOfWorkInWinforms.Domain.Entities;

namespace RepositoryPatternAndUnitOfWorkInWinforms.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public  DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration=new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            optionsBuilder.UseLazyLoadingProxies()
                .UseSqlServer(connectionString: configuration.GetConnectionString("cn"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
