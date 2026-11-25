using Microsoft.EntityFrameworkCore;
using OpenSmartEnum.EFCore.IntegrationTests.Entities;

namespace OpenSmartEnum.EFCore.IntegrationTests.DbContext1
{
    /// <summary>
    /// This DbContext configures SmartEnum via the OnModelCreating extension method.
    /// </summary>
    public class TestDbContext1 : Microsoft.EntityFrameworkCore.DbContext
    {
        public TestDbContext1(DbContextOptions<TestDbContext1> options) : base(options)
        { }

        public TestDbContext1()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SomeEntity.Configuration());
            modelBuilder.ConfigureSmartEnum();
        }

        public DbSet<SomeEntity> SomeEntities { get; set; }
    }
}