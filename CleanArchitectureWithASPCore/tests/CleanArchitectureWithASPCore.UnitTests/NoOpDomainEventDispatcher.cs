using CleanArchitectureWithASPCore.SharedKernel;
using CleanArchitectureWithASPCore.SharedKernel.Interfaces;
using System.Threading.Tasks;

namespace CleanArchitectureWithASPCore.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}
