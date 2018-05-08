using System.Collections.Generic;

namespace ISSApp.Repository
{
    public interface ISqlRepo<T>
    {
        void Add(T entity);
        T Delete(T entity);
        T Update(T entity);
        T FindEntity(int id);
        List<T> FindAll();
    }
}