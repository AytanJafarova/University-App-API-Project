using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IPreExamRepository
    {
        List<PreExam> Get();
        PreExam Get(int id);
        void Add(PreExam preexam);
        void Update(PreExam preexam);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
