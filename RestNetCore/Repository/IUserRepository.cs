using RestNetCore.Data.VO;
using RestNetCore.Model;

namespace RestNetCore.Repository
{
    public interface IUserRepository
    {
        User ValidateCredentials(UserVO user);
        User ValidateCredentials(string userName);
        bool RevokeToken(string userName);
        User RefreshUserInfo(User user);

    }
}
