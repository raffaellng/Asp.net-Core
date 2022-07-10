using RestNetCore.Model;
using RestNetCore.Repository;
using System.Collections.Generic;

namespace RestNetCore.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {

        private readonly IRepository<Books> _repository;

        public BooksBusinessImplementation(IRepository<Books> repository)
        {
            _repository = repository;
        }

        public List<Books> FindByall()
        {
            return _repository.FindByAll();
        }

        public Books FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Books Create(Books books)
        {
            return _repository.Create(books);
        }

        public Books Update(Books books)
        {
            return _repository.Update(books);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
