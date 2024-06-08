using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoMapperExample
{
    public class EmployeeA
    {
        public int Id { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Country { get; set; }
        public SalaryA? Salary { get; set; }
        public int ZipCode { get; set; }
    }

    public class SalaryA
    {
        public decimal BaseSalary { get; set; }
        public decimal TaxBenifits { get; set;}
    }
}
