using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperExample
{
    public class TotalValueResolver : IValueResolver<EmployeeA, EmployeeB, decimal>
    {
        public decimal Resolve(EmployeeA source, EmployeeB destination, decimal destMember, ResolutionContext context)
        {
            return source.Salary.BaseSalary + source.Salary.TaxBenifits;
        }
    }
}
