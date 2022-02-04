using Employee.Domain.Abstractions.Models;
using Employee.Domain.Enums;

namespace Employee.Domain.Models
{
    public class Employee : DomainEntity
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
        public Gender Gender { get; set; }
    }
}
