using RestNetCore.Data.VO;
using System.Collections.Generic;

namespace RestNetCore.Business
{
    public interface IBooksBusiness
    {
        BooksVO Create(BooksVO books);
        BooksVO FindById(long id);
        List<BooksVO> FindByall();
        BooksVO Update(BooksVO books);
        void Delete(long id);
    }
}
