using Core.Domain.Concrete;
using Core.Persistence.EntityFramework;

namespace Business.Services;

public interface IOperationClaimRepository : IAsyncRepository<OperationClaim>, IRepository<OperationClaim>
{
}