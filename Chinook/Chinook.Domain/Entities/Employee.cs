using Chinook.Domain.Common;
using System;
using System.Collections.Generic;

namespace Chinook.Domain.Entities
{
    public partial class Employee: BaseAuditableEntity
    {
        public Employee()
        {
            Customers = new HashSet<Customer>();
            InverseReportsToNavigation = new HashSet<Employee>();
        }

        public string LastName { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? Title { get; set; }
        public long? ReportsTo { get; set; }
        public byte[]? BirthDate { get; set; }
        public byte[]? HireDate { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }

        public virtual Employee? ReportsToNavigation { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Employee> InverseReportsToNavigation { get; set; }
    }
}
