using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class ParentConfiguration : IEntityTypeConfiguration<Parent>
{
    public void Configure(EntityTypeBuilder<Parent> builder)
    {
        builder.Property(p => p.FirstName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(p => p.LastName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(p => p.Phone).HasColumnType("nvarchar(MAX)").IsRequired(true);
    }
}
