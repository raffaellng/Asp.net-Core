using RestNetCore.Model;
using System.Collections.Generic;

namespace RestNetCore.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindByall();
        Person Update(Person person);
        void Delete(long id);
    }
}
