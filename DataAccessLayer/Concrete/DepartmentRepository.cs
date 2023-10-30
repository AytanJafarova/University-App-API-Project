using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly UniDbContext _uniDbContext;
        public DepartmentRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Department department)
        {
            _uniDbContext.Departments.Add(department);
            _uniDbContext.ChangeTracker.DetectChanges();
            Console.WriteLine(_uniDbContext.ChangeTracker.DebugView.ShortView);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = _uniDbContext.Departments.Find(id);
            _uniDbContext.Departments.Remove(department);
            _uniDbContext.ChangeTracker.DetectChanges();
            Console.WriteLine(_uniDbContext.ChangeTracker.DebugView.LongView);
            _uniDbContext.SaveChanges();
        }

        public List<Department> Get()
        {
            IQueryable<Department> departments = _uniDbContext.Departments.Include(d => d.Courses).AsNoTracking().OrderBy(d=>d.DepartmentName);
            return departments.ToList();
        }

        public Department Get(int id)
        {
            return _uniDbContext.Departments.Where(d => d.DepartmentId == id).Include(d => d.Courses).Single();
        }

        public void SoftDelete(int id)
        {
            var department = _uniDbContext.Departments.Find(id);
            department.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Department department)
        {
            _uniDbContext.Departments.Update(department);
            _uniDbContext.ChangeTracker.DetectChanges();
            Console.WriteLine(_uniDbContext.ChangeTracker.DebugView.LongView);
            _uniDbContext.SaveChanges();
        }
    }
}
