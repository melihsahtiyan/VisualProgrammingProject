using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Domain.Concrete
{
    public class UserOperationClaim : Entity
    {
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }

        public UserOperationClaim() { }

        public UserOperationClaim(int id, int userId, int operationClaimId) : base(id)
        {
            UserId = userId;
            OperationClaimId = operationClaimId;
        }
    }
}
