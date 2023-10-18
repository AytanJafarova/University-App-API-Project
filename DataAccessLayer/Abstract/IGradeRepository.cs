using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IGradeRepository
    {
        List<Grade> Get();
        Grade Get(int id);
        void Add(Grade grade);
        void Update(Grade grade);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
        int TotalGrade(Grade grade);

    }
}
