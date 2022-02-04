using Employee.Domain.Abstractions.Models;

namespace Employee.Domain.Models
{
    public class EmployeeModel : IDomainEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string BirthDate { get; set; }
    }
}
