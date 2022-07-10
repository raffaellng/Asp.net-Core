using RestNetCore.Model;
using System.Collections.Generic;

namespace RestNetCore.Business
{
    public interface IBooksBusiness
    {
        Books Create(Books books);
        Books FindById(long id);
        List<Books> FindByall();
        Books Update(Books books);
        void Delete(long id);
    }
}
