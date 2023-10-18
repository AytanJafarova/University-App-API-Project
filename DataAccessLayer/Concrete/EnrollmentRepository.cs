using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly UniDbContext _uniDbContext;
        public EnrollmentRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Enrollment enrollment)
        {
            _uniDbContext.Enrollments.Add(enrollment);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var enrollment = _uniDbContext.Enrollments.Find(id);
            _uniDbContext.Enrollments.Remove(enrollment);
            _uniDbContext.SaveChanges();
        }

        public List<Enrollment> Get()
        {
           return _uniDbContext.Enrollments.Include(e=>e.Group).Include(e=>e.Course).Include(e=>e.Teacher).ToList();
        }

        public Enrollment Get(int id)
        {
            return _uniDbContext.Enrollments.Where(e=>e.EnrollmentId == id).Include(e => e.Group).Include(e => e.Course).Include(e => e.Teacher).Single();
        }

        public void SoftDelete(int id)
        {
            var enrollment = _uniDbContext.Enrollments.Find(id);
            enrollment.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Enrollment enrollment)
        {
            _uniDbContext.Enrollments.Update(enrollment);
            _uniDbContext.SaveChanges();
        }
    }
}
