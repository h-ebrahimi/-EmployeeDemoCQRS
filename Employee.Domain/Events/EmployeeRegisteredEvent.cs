using Employee.Domain.Abstractions.Events;
using System;

namespace Employee.Domain.Models
{
    public class EmployeeRegisteredEvent : DomainEvent
    {
        public Employee Employee { get; }

        public EmployeeRegisteredEvent(Employee employee) => Employee = employee ?? throw new ArgumentNullException(nameof(employee));
    }
}
