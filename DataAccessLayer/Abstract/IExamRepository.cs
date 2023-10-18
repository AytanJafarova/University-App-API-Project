using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IExamRepository
    {
        List<Exam> Get();
        Exam Get(int id);
        void Add(Exam exam);
        void Update(Exam exam);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
