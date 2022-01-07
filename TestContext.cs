using Microsoft.EntityFrameworkCore;
using Template.Entities;
using Template.EntityConfigurations;

namespace Template
{
    public class TestContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }
        public DbSet<ChildEntity> ChildEntities { get; set; }

        public TestContext(DbContextOptions<TestContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EntityConfiguration());
            modelBuilder.ApplyConfiguration(new ChildConfiguration());
        }
    }
}