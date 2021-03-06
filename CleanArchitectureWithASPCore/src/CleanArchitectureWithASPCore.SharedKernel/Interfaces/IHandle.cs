using CleanArchitectureWithASPCore.SharedKernel;
using System.Threading.Tasks;

namespace CleanArchitectureWithASPCore.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}