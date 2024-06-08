using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperExample
{
    public class EmployeeB
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Nation { get; set; }
        public SalaryB? Salary { get; set; }
        public int PostalCode { get; set; }
        public decimal Total {  get; set; }

    }
    public class SalaryB
    {
        public decimal BaseSalary { get; set; }
        public decimal TaxBenifits { get; set; }
    }
}
