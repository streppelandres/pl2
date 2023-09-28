using AutoMapper;
using SysacadApi.Application.DTOs;
using SysacadApi.Core.Entities;

namespace SysacadApi.Application
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Course, CourseDTO>();
            CreateMap<Student, StudentDTO>();
        }
    }
}
