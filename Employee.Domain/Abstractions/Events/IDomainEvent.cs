using MediatR;

namespace Employee.Domain.Abstractions.Events
{
    public interface IDomainEvent : INotification
    {
        long OccurTime { get; }
    }
}