using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IEnrollmentRepository
    {
        List<Enrollment> Get();
        Enrollment Get(int id);
        void Add(Enrollment enrollment);
        void Update(Enrollment enrollment);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
