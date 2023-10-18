using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IGroupRepository
    {
        List<Group> Get();
        Group Get(int id);
        void Add(Group group);
        void Update(Group group);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
