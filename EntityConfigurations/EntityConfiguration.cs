using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Entities;

namespace Template.EntityConfigurations
{
    public class EntityConfiguration : IEntityTypeConfiguration<Entity>
    {
        public void Configure(EntityTypeBuilder<Entity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(nameof(Entity.Id)).ValueGeneratedOnAdd();

            builder
                .HasMany(x => x.Children)
                .WithOne()
                .HasForeignKey(x => x.ParentId);
        }
    }
}