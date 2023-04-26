﻿using Core.Domain.Concrete;
using Core.Persistence.EntityFramework;

namespace Business.Services;

public interface IUserOperationClaimRepository : IAsyncRepository<UserOperationClaim>, IRepository<UserOperationClaim>
{
}