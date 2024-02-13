using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class CarConfiguration : IEntityTypeConfiguration<Car>
{
    public void Configure(EntityTypeBuilder<Car> builder)
    {
        builder.Property(c => c.CarName).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(c => c.CarNumber).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(c => c.SeatCount).HasColumnType("int").IsRequired(true);
    }
}
