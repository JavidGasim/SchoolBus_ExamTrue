using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_Model.Entities.Concrete;

public class Driver : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone {  get; set; }
    public string HomeAddress { get; set; }
    public string License { get; set; }

    public Driver()
    {
        
    }
}
