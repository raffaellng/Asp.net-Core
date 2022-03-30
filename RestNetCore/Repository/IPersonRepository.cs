using RestNetCore.Model;
using System.Collections.Generic;

namespace RestNetCore.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindByAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
