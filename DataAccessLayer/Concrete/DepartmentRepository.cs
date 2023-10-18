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
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var department = _uniDbContext.Departments.Find(id);
            _uniDbContext.Departments.Remove(department);
            _uniDbContext.SaveChanges();
        }

        public List<Department> Get()
        {
           return _uniDbContext.Departments.Include(d=>d.Courses).ToList();
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
            _uniDbContext.SaveChanges();
        }
    }
}
