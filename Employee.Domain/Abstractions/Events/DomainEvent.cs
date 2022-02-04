using Employee.Common;
using System;

namespace Employee.Domain.Abstractions.Events
{
    public class DomainEvent : IDomainEvent
    {
        public long OccurTime { get; }
        public DomainEvent()
        {
            OccurTime = DateTime.Now.ToMilliseconds();
        }
    }
}