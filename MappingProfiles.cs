using AutoMapper;
using AutoMapper.Configuration.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperExample
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles() 
        {
            CreateMap<EmployeeA, EmployeeB>()
                .ForMember(dest => dest.Nation, opt => opt.MapFrom(src => src.Country))
                //.AddTransform<string>(x => x.ToUpper())
                //.ForMember(dest => dest.Salary, opt => opt.Ignore())
                .ForMember(dest => dest.Total, opt => opt.MapFrom<TotalValueResolver>())
                .ForMember(dest => dest.Total, opt => opt.PreCondition(src => src.Salary is not null))
                //.ForMember(dest => dest.FirstName, opt => opt.NullSubstitute("No Name"))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName == "" || src.FirstName == null ? "First Input Your Name" : src.FirstName))
                ;

            CreateMap<SalaryA, SalaryB>();
        }
    }
}
