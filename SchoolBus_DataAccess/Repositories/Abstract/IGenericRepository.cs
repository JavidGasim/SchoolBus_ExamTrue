using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_DataAccess.Repositories.Abstract;

public interface IGenericRepository<T> where T : BaseEntity, new()
{
    ICollection<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Remove(T entity);
    void Save();
}
