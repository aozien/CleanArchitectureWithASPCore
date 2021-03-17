using CleanArchitectureWithASPCore.SharedKernel;
using System.Threading.Tasks;

namespace CleanArchitectureWithASPCore.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}