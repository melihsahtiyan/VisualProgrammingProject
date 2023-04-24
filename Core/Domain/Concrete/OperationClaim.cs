using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Abstract;

namespace Core.Domain.Concrete
{
    public class OperationClaim : Entity
    {
        public string OperationClaimName { get; set; }
        public virtual ICollection<UserOperationClaim> UserOperationClaims { get; set; }

        public OperationClaim()
        {
        }

        public OperationClaim(int id, string operationClaimName) : base(id)
        {
            OperationClaimName = operationClaimName;
        }
    }
}
