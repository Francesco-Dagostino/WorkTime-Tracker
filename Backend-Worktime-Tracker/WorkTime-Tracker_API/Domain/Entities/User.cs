using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string UserName { get; set; } = string.Empty;
        public Roles Role { get; set; }

        public int CompanyId { get; private set; }

        public User() { }
    }
}
