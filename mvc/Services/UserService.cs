using mvc.Interfaces;
using mvc.Models.Requests;
using mvc.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace mvc.Services
{
    public class UserService : IUserService
    {
        public UserResponseModel CreateUser(CreateUserRequestModel model)
        {
            if(model == null)
                throw new ArgumentNullException($"{nameof(model)} cannot be null.");

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

        public IEnumerable<UserResponseModel> GetUsers(int pageIndex, int pageSize)
        {
            var userList = GenerateUserList();
            var index = pageIndex <= 0 ? 0 : pageIndex - 1;
            var size = pageSize < 0 ? 0 : pageSize;

            return userList
                .Skip(index * size)
                .Take(size);
        }

        // Fake a list of user objects as if they are fetched from a db
        private IEnumerable<UserResponseModel> GenerateUserList()
        {
            var userList = new List<UserResponseModel>();
            for (int i = 0; i < 100; i++)
            {
                userList.Add(new UserResponseModel
                {
                    UserId = i,
                    FirstName = "John",
                    LastName = $"Doe {i}"
                });
            }

            return userList;
        }

        public void DeleteUser(int userId)
        {
            // It's not relevant to implement Delete: we have no db
            return;
        }
    }
}
