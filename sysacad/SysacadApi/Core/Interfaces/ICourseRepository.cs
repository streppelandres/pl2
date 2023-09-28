using SysacadApi.Core.Entities;

namespace SysacadApi.Core.Interfaces
{
    public interface ICourseRepository
    {
        ICollection<Course> GetAll();
        Course Create(string name);
    }
}
