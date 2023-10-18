using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class ExamRepository : IExamRepository
    {
        private readonly UniDbContext _uniDbContext;
        public ExamRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Exam exam)
        {
            if(exam.ExamDate == null)
            {
                exam.ExamDate = DateTime.Now;
            }
            _uniDbContext.Exams.Add(exam);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var exam = _uniDbContext.Exams.Find(id);
            _uniDbContext.Exams.Remove(exam);
            _uniDbContext.SaveChanges();
        }

        public List<Exam> Get()
        {
           return _uniDbContext.Exams.Include(e=>e.Course).ToList();
        }

        public Exam Get(int id)
        {
            return _uniDbContext.Exams.Where(d => d.ExamId == id).Include(e => e.Course).Single();
        }

        public void SoftDelete(int id)
        {
            var exam = _uniDbContext.Exams.Find(id);
            exam.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Exam exam)
        {
            _uniDbContext.Exams.Update(exam);
            _uniDbContext.SaveChanges();
        }
    }
}
