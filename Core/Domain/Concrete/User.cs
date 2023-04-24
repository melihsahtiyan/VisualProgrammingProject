using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Concrete
{
    public class User : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string IdentityNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime BirthDate{ get; set; }
        public bool Status { get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }

        public User()
        {
        }

        public User(int id, string firstName, string lastName, string email, string identityNumber, byte[] passwordHash,
            byte[] passwordSalt, DateTime birthDate, bool status) : base(id)

        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            IdentityNumber = identityNumber;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            BirthDate = birthDate;
            Status = status;
        }

    }
}
