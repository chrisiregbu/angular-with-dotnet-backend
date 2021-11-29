using System;
using System.Collections.Generic;

namespace angularwithdotnetbackend.Models
{
    public interface IUserRepository
    {
        IEnumerable<UserModel> GetAll();
        
        UserModel Add(UserModel user);
    }
}