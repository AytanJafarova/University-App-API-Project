using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class PreExamRepository : IPreExamRepository
    {
        private readonly UniDbContext _uniDbContext;
        public PreExamRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(PreExam preExam)
        {
            _uniDbContext.PreExams.Add(preExam);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var preExam = _uniDbContext.PreExams.Find(id);
            _uniDbContext.PreExams.Remove(preExam);
            _uniDbContext.SaveChanges();
        }

        public List<PreExam> Get()
        {
           return _uniDbContext.PreExams.Include(p=>p.Course).Include(p => p.Student).ToList();
        }

        public PreExam Get(int id)
        {
            return _uniDbContext.PreExams.Where(p=>p.PreExamId == id).Include(p => p.Course).Include(p => p.Student).Single();
        }

        public void SoftDelete(int id)
        {
            var preExam = _uniDbContext.PreExams.Find(id);
            preExam.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(PreExam preExam)
        {
            _uniDbContext.PreExams.Update(preExam);
            _uniDbContext.SaveChanges();
        }
    }
}
