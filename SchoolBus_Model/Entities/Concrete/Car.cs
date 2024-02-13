using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_Model.Entities.Concrete;

public class Car : BaseEntity
{
    public string CarName { get; set; }
    public string CarNumber { get; set; }
    public int SeatCount { get; set; }

    public Car()
    {
        
    }
}
