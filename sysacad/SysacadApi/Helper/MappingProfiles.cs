using AutoMapper;
using SysacadApi.Dto;
using SysacadApi.Models;

namespace SysacadApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Administrator, AdministratorDto>();
            CreateMap<Course, CourseDto>();
            CreateMap<Student, StudentDto>();
        }
    }
}
