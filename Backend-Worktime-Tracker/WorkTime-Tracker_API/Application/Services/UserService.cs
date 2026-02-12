using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class UserService
    {
        public User Get(string name)
        {
            return new User() { Name = name };
        }
    }
}
