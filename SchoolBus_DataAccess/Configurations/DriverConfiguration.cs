using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class DriverConfiguration : IEntityTypeConfiguration<Driver>
{
    public void Configure(EntityTypeBuilder<Driver> builder)
    {
        builder.Property(d => d.FirstName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(d => d.LastName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(d => d.HomeAddress).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(d => d.License).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(d => d.Phone).HasColumnType("nvarchar(MAX)").IsRequired(true);
    }
}
