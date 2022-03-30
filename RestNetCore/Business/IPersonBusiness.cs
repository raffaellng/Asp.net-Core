using RestNetCore.Model;
using System.Collections.Generic;

namespace RestNetCore.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindByall();
        Person Update(Person person);
        void Delete(long id);
    }
}
