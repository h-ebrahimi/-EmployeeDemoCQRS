using Employee.Domain.Abstractions.Events;
using System.Collections.Generic;

namespace Employee.Domain.Abstractions.Models
{
    public abstract class DomainEntity : IDomainEntity
    {
        private readonly List<IDomainEvent> domainEvents = new();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();
        public int Id { get; set; }

        public void AddDomainEvent(IDomainEvent eventItem) => domainEvents.Add(eventItem);
        public void ClearDomainEvents() => domainEvents?.Clear();
        public void RemoveDomainEvent(IDomainEvent eventItem) => domainEvents?.Remove(eventItem);
    }
}
