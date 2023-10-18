using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private readonly UniDbContext _uniDbContext;
        public StudentRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Student student)
        {
            _uniDbContext.Students.Add(student);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var student = _uniDbContext.Students.Find(id);
            _uniDbContext.Students.Remove(student);
            _uniDbContext.SaveChanges();
        }

        public List<Student> Get()
        {
           return _uniDbContext.Students.Include(s=>s.Account).Include(s=>s.Group).Include(s => s.PreExams).Include(s => s.Grades).ToList();
        }

        public Student Get(int id)
        {
            return _uniDbContext.Students.Where(s=>s.StudentId == id).Include(s => s.Account).Include(s => s.Group).Include(s => s.PreExams).Include(s => s.Grades).Single();
        }

        public void SoftDelete(int id)
        {
            var student = _uniDbContext.Students.Find(id);
            student.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Student student)
        {
            _uniDbContext.Students.Update(student);
            _uniDbContext.SaveChanges();
        }
    }
}
