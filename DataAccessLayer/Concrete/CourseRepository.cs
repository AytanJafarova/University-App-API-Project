using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniDbContext _uniDbContext;
        public CourseRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Course course)
        {
            if(course.Credit == 0 || course.Credit == null)
            {
                course.Credit = 1;
            }
            if(course.Duration == 0 || course.Duration == null)
            {
                course.Duration = 1;
            }
            _uniDbContext.Courses.Add(course);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var course = _uniDbContext.Courses.Find(id);
            _uniDbContext.Courses.Remove(course);
            _uniDbContext.SaveChanges();
        }

        public List<Course> Get()
        {
            return _uniDbContext.Courses.Include(c=>c.Department).Include(c=>c.Exams).Include(c=>c.PreExams).Include(c=>c.Enrollments).ToList();
        }

        public Course Get(int id)
        {
            return _uniDbContext.Courses.Where(c=>c.CourseId == id).Include(c => c.Department).Include(c => c.Exams).Include(c => c.PreExams).Include(c => c.Enrollments).Single();
        }

        public void SoftDelete(int id)
        {
            var course = _uniDbContext.Courses.Find(id);
            course.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Course course)
        {
            if (course.Credit == 0 || course.Credit == null)
            {
                course.Credit = 1;
            }
            if (course.Duration == 0 || course.Duration == null)
            {
                course.Duration = 1;
            }
            _uniDbContext.Courses.Update(course);
            _uniDbContext.SaveChanges();
        }
    }
}
