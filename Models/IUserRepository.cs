using System;
using System.Collections.Generic;

namespace angular_with_dotnet_backend.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }
}