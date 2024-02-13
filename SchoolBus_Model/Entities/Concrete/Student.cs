using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_Model.Entities.Concrete;

public class Student : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string ParentName {  get; set; }
    public string HomeAddress { get; set; }

    public Student()
    {
        
    }
}
