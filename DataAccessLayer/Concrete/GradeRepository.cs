using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class GradeRepository : IGradeRepository
    {
        private readonly UniDbContext _uniDbContext;
        public GradeRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Grade grade)
        {
            if(grade.PreExam.Midterm == null)
            {
                grade.PreExam.Midterm = 0;
            }
            if (grade.PreExam.Activity == null)
            {
                grade.PreExam.Activity = 0;
            }
            if (grade.PreExam.Attendance == null)
            {
                grade.PreExam.Midterm = 0;
            }
            if (grade.PreExam.Presentation == null)
            {
                grade.PreExam.Midterm = 0;
            }
            grade.TotalGrade = grade.ExamGrade + (int)(grade.PreExam.Midterm + grade.PreExam.Activity + grade.PreExam.Attendance + grade.PreExam.Presentation + grade.PreExam.Quiz);
            _uniDbContext.Grades.Add(grade);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var grade = _uniDbContext.Grades.Find(id);
            _uniDbContext.Grades.Remove(grade);
            _uniDbContext.SaveChanges();
        }

        public List<Grade> Get()
        {
           return _uniDbContext.Grades.Include(g=>g.Student).Include(g=>g.Exam).Include(g=>g.PreExam).ToList();
        }

        public Grade Get(int id)
        {
            return _uniDbContext.Grades.Where(g => g.GradeId == id).Include(g => g.Student).Include(g => g.Exam).Include(g => g.PreExam).Single();
        }

        public void SoftDelete(int id)
        {
            var grade = _uniDbContext.Grades.Find(id);
            grade.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Grade grade)
        {
            _uniDbContext.Grades.Update(grade);
            _uniDbContext.SaveChanges();
        }
        public int TotalGrade(Grade grade)
        {
            return 0;
        }
    }
}
