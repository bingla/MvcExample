using System.Collections.Generic;
using mvc.Models.Requests;
using mvc.Models.Responses;

namespace mvc.Interfaces
{
    public interface IUserService
    {
        UserResponseModel CreateUser(CreateUserRequestModel model);
        UserResponseModel GetUser(int userId);
        IEnumerable<UserResponseModel> GetUsers(int pageIndex, int pageSize);
        void DeleteUser(int userId);
    }
}
