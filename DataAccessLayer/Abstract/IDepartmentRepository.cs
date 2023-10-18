using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IDepartmentRepository
    {
        List<Department> Get();
        Department Get(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
