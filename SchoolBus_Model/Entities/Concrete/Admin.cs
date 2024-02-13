using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_Model.Entities.Concrete;

public class Admin : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public Admin()
    {
        
    }
}
