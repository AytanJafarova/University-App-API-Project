using Entities;

namespace DataAccessLayer.Abstract
{
    public interface ITeacherRepository
    {
        List<Teacher> Get();
        Teacher Get(int id);
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
