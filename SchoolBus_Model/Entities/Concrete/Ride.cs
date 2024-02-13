using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_Model.Entities.Concrete;

public class Ride : BaseEntity
{
    public string FromWhere { get; set; }
    public string ToWhere { get; set; }
    public string CarName { get; set; }
    public string CarNumber { get; set; }
    public int StudentAttend { get; set; }
    public int MaxSeat { get; set; }

    public Ride()
    {
        StudentAttend = 0;
    }
}
