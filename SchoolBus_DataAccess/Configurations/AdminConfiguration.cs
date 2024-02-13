using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class AdminConfiguration : IEntityTypeConfiguration<Admin>
{
    public void Configure(EntityTypeBuilder<Admin> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.FirstName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(a => a.LastName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(a => a.Email).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(a => a.Password).HasColumnType("nvarchar(MAX)").IsRequired(true);
    }
}
