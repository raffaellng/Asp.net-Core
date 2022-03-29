using RestNetCore.Model;
using RestNetCore.Model.Context;
using RestNetCore.Repository;
using System.Collections.Generic;
using System.Linq;

namespace RestNetCore.Business.Implementations
{
    public class PersonBusiness : IPersonBusiness
    {

        private readonly IPersonRepository _repository;

        public PersonBusiness(IPersonRepository repository)
        {
            _repository = repository;
        }

        public List<Person> FindByall()
        {
            return _repository.FindByAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Create(Person person)
        {
            try
            {
                _repository.Create(person);
            }
            catch (System.Exception)
            {
                throw;
            }

            return person;
        }

        public Person Update(Person person)
        {
            return _repository.Update(person); ;
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
