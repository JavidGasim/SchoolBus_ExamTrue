using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolBus_Model.Entities.Concrete;

namespace SchoolBus_DataAccess.Configurations;

public class RideConfiguration : IEntityTypeConfiguration<Ride>
{
    public void Configure(EntityTypeBuilder<Ride> builder)
    {
        builder.Property(r => r.CarNumber).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(r => r.MaxSeat).HasColumnType("int").IsRequired(true);
        builder.Property(r => r.FromWhere).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(r => r.ToWhere).HasColumnType("nvarchar(MAX)").IsRequired(true);
        builder.Property(r => r.CarName).HasColumnType("nvarchar(MAX)").IsRequired(true);
    }
}
