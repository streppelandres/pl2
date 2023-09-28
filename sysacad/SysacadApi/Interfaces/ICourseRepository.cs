using SysacadApi.Models;

namespace SysacadApi.Interfaces
{
    public interface ICourseRepository
    {
        ICollection<Course> GetAll();
        Course Create(string name);
    }
}
