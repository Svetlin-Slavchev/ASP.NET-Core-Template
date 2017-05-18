using SampleProject.Entities.Abstraction;
using System.Linq;

namespace SampleProject.Abstraction.Data
{
    public interface IDbRepository<T>
        where T : class, IDeletableEntity
    {
        IQueryable<T> All();

        IQueryable<T> AllWithDeleted();

        T GetById(object id);

        void Add(T entity);

        void Delete(T entity);

        void HardDelete(T entity);

        void Save();

        void Dispose();
    }
}
