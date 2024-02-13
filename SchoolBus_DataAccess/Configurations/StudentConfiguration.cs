using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Property(s => s.HomeAddress).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(s => s.FirstName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(s => s.LastName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(s => s.ParentName).HasColumnType("nvarchar(MAX)").IsRequired(true);
    }
}
