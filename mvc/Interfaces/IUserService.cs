using mvc.Models.Requests;
using mvc.Models.Responses;

namespace mvc.Interfaces
{
    public interface IUserService
    {
        UserResponseModel CreateUser(CreateUserRequestModel model);
        UserResponseModel GetUser(int userId);
        void DeleteUser(int userId);
    }
}
