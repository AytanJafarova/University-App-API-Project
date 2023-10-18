using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly UniDbContext _uniDbContext;
        public TeacherRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Teacher teacher)
        {
            _uniDbContext.Teachers.Add(teacher);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var teacher = _uniDbContext.Teachers.Find(id);
            _uniDbContext.Teachers.Remove(teacher);
            _uniDbContext.SaveChanges();
        }

        public List<Teacher> Get()
        {
           return _uniDbContext.Teachers.Include(t=>t.Account).Include(t=>t.Department).Include(t=>t.Enrollments).ToList();
        }

        public Teacher Get(int id)
        {
            return _uniDbContext.Teachers.Where(t => t.TeacherId == id).Include(t => t.Account).Include(t => t.Department).Include(t => t.Enrollments).Single();
        }

        public void SoftDelete(int id)
        {
            var teacher = _uniDbContext.Teachers.Find(id);
            teacher.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Teacher teacher)
        {
            _uniDbContext.Teachers.Update(teacher);
            _uniDbContext.SaveChanges();
        }
    }
}
