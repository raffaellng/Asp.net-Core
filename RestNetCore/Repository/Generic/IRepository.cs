using RestNetCore.Model;
using RestNetCore.Model.Base;
using System.Collections.Generic;

namespace RestNetCore.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(long id);
        List<T> FindByAll();
        T Update(T item);
        void Delete(long id);
        bool Exists(long id);
    }
}
