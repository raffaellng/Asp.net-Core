using RestNetCore.Data.VO;
using System.Collections.Generic;

namespace RestNetCore.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long id);
        List<PersonVO> FindByall();
        PersonVO Update(PersonVO person);
        void Delete(long id);
    }
}
