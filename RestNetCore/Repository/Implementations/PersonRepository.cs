using RestNetCore.Model;
using RestNetCore.Model.Context;
using System.Collections.Generic;
using System.Linq;

namespace RestNetCore.Repository.Implementations
{
    public class PersonRepository : IPersonRepository
    {

        private MySQLContext _context;

        public PersonRepository(MySQLContext context)
        {
            _context = context;
        }

        public List<Person> FindByAll()
        {
            return _context.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return ExistsForGet(id);
        }

        public Person Create(Person person)
        {
            try
            {
                _context.Add(person);
                _context.SaveChanges();
            }
            catch (System.Exception)
            {
                throw;
            }

            return person;
        }

        public Person Update(Person person)
        {
            if (!ExistsForUpdate(person.Id)) return new Person();

            var result = ExistsForGet(person.Id);

            if (result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(person);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }

            return person;
        }

        public void Delete(long id)
        {
            var result = ExistsForGet(id);

            if (result != null)
            {
                try
                {
                    _context.Persons.Remove(result);
                    _context.SaveChanges();
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
        }

        private bool ExistsForUpdate(long id)
        {
            return _context.Persons.Any(p => p.Id.Equals(id));
        }

        private Person ExistsForGet(long id)
        {
            return _context.Persons.SingleOrDefault(p => p.Id.Equals(id));
        }
    }
}
