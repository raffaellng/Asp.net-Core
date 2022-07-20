using RestNetCore.Data.Convert.Implementantions;
using RestNetCore.Data.VO;
using RestNetCore.Model;
using RestNetCore.Repository;
using System.Collections.Generic;

namespace RestNetCore.Business.Implementations
{
    public class BooksBusinessImplementation : IBooksBusiness
    {

        private readonly IRepository<Books> _repository;
        private readonly BooksConverter _converter;

        public BooksBusinessImplementation(IRepository<Books> repository)
        {
            _repository = repository;
            _converter = new BooksConverter();
        }

        public List<BooksVO> FindByall()
        {
            return _converter.Parse(_repository.FindByAll());
        }

        public BooksVO FindById(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        public BooksVO Create(BooksVO books)
        {
            var booksEntity = _converter.Parse(books);
            booksEntity = _repository.Create(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public BooksVO Update(BooksVO books)
        {
            var booksEntity = _converter.Parse(books);
            booksEntity = _repository.Update(booksEntity);
            return _converter.Parse(booksEntity);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
