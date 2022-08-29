using RestNetCore.Data.VO;

namespace RestNetCore.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidadeCredentials(UserVO user);
        TokenVO ValidadeCredentials(TokenVO token);
        bool RevokeToken(string userName);
    }
}
