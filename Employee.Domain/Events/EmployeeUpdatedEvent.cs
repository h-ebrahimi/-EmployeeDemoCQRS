using Employee.Domain.Abstractions.Events;
using System;

namespace Employee.Domain.Models
{
    public class EmployeeUpdatedEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeUpdatedEvent(Employee employee) => Employee = employee ?? throw new ArgumentNullException(nameof(employee));
    }
}
