using Microsoft.EntityFrameworkCore;
using SchoolBus_DataAccess.Contexts;
using SchoolBus_DataAccess.Repositories.Abstract;
using SchoolBus_Model.Entities.Abstract;

namespace SchoolBus_DataAccess.Repositories.Concrete;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
{
    internal readonly SchoolBusDB _context;
    internal readonly DbSet<T> _entity;

    public GenericRepository()
    {
        _context = new SchoolBusDB();
        _entity = _context.Set<T>();
    }


    public void Add(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");
        _entity.Add(entity);
    }

    public ICollection<T> GetAll()
    {
        return _entity.ToList();
    }

    public void Remove(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");

        var isChechk = _entity.FirstOrDefault(a => a.Id == entity.Id);

        if (isChechk == null) throw new Exception("Entity Not Found");
        _entity.Remove(entity);
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        if (entity == null) throw new Exception("Entity Is NULL");

        var isChechk = _entity.FirstOrDefault(a => a.Id == entity.Id);

        if (isChechk == null) throw new Exception("Entity Not Found");


        _entity.Update(entity);
    }
}
