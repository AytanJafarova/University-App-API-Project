using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IStudentRepository
    {
        List<Student> Get();
        Student Get(int id);
        void Add(Student student);
        void Update(Student student);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
