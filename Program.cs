//Console.WriteLine("Hello, World!");

using AutoMapper;

namespace AutoMapperExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<EmployeeA> 
            {
                new EmployeeA
                {
                    Id = 1,
                    FirstName = "",
                    LastName = "Doe",
                    Country = "USA",
                    DateOfBirth = new DateTime(1997, 03, 13),
                    Salary = new SalaryA
                    {
                        BaseSalary = 30000,
                        TaxBenifits = 2000
                    },
                    ZipCode = 1234
                },
                new EmployeeA
                {
                    Id = 2,
                    FirstName = "Adam",
                    LastName = "Greens",
                    Country = "Australia",
                    DateOfBirth = new DateTime(1996, 08, 22),
                    /*Salary = new SalaryA
                    {
                        BaseSalary = 40000,
                        TaxBenifits = 2500
                    },*/
                    ZipCode = 8965
                }
            };

            var mapperConfiguration = new MapperConfiguration(config =>
            {
                config.AddProfile(new MappingProfiles());
                //config.ReplaceMemberName("Country", "Nation");
                config.ReplaceMemberName("Zip","Postal");
                config.AllowNullCollections = true;
            }); 

            var mapper = mapperConfiguration.CreateMapper();

            //EmployeeB result = mapper.Map<EmployeeB>(johnDoe);
            List<EmployeeB> result = mapper.Map<List<EmployeeB>>(employees);

            //Console.WriteLine($"Id: {result.Id}, \nFirstName: {result.FirstName}, \nLastName: {result.LastName}, \nNation: {result.Nation}, \nDateOfBirth: {result.DateOfBirth.ToShortDateString()}, \nSalary: ");
            //Console.WriteLine($"\tBaseSalary: {result.Salary.BaseSalary}, \n\tTaxBenefits: {result.Salary.TaxBenifits}, \nPostalCode: {result.PostalCode}");
            foreach (var employee in result)
            {
                Console.WriteLine($"Id: {employee.Id}, \nFirstName: {employee.FirstName}, \nLastName: {employee.LastName}, \nNation: {employee.Nation}, \nDateOfBirth: {employee.DateOfBirth.ToShortDateString()}, \nSalary: ");
                if (employee.Salary != null)
                {
                    Console.WriteLine($"\tBaseSalary: {employee.Salary.BaseSalary}, \n\tTaxBenefits: {employee.Salary.TaxBenifits}");
                }
                else
                {
                    Console.WriteLine("\tSalary details are not available.");
                }
                Console.WriteLine($"TotalSalary: {employee.Total}");
                Console.WriteLine($"PostalCode: {employee.PostalCode}");
            }

        }
    }
}