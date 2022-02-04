using MediatR;

namespace Employee.Domain.Abstractions.Events
{
    public interface IDomainEventHandler<TEvent> : INotificationHandler<TEvent> where TEvent : IDomainEvent
    {
    }
}