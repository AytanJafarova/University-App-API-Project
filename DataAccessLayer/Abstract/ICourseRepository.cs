using Entities;

namespace DataAccessLayer.Abstract
{
    public interface ICourseRepository
    {
        List<Course> Get();
        Course Get(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
