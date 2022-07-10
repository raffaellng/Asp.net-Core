using System.Collections.Generic;

namespace RestNetCore.Data.Contract
{
    public interface IParser<O, D>
    {
        D Parse(O origin);
        List<D> Parse(List<O> origin);
    }
}
