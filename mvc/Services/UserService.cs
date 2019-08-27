using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using mvc.Interfaces;
using mvc.Models.Requests;
using mvc.Models.Responses;

namespace mvc.Services
{
    public class UserService : IUserService
    {
        public UserResponseModel CreateUser(CreateUserRequestModel model)
        {
            if(model == null)
                throw new ArgumentNullException("Something was null");

            var result = new UserResponseModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName
            };

            return result;
        }

        public UserResponseModel GetUser(int userId)
        {
            var response = new UserResponseModel
            {
                UserId = 1,
                FirstName = "John",
                LastName = "Doe"
            };

            return response;
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
