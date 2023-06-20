using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Concrete
{
    public class User : Entity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool Status { get; set; }

        public User()
        {
        }

        public User(int id, string name, string email, byte[] passwordHash,
            byte[] passwordSalt, bool status) : base(id)

        {
            Name = name;
            Email = email;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Status = status;
        }

    }
}
