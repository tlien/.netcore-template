using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Template.Entities;

namespace Template.EntityConfigurations
{
    public class ChildConfiguration : IEntityTypeConfiguration<ChildEntity>
    {
        public void Configure(EntityTypeBuilder<ChildEntity> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(nameof(ChildEntity.Id)).ValueGeneratedOnAdd();
        }
    }
}