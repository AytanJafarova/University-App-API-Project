using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class GroupRepository : IGroupRepository
    {
        private readonly UniDbContext _uniDbContext;
        public GroupRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Group group)
        {
            _uniDbContext.Groups.Add(group);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var group = _uniDbContext.Groups.Find(id);
            _uniDbContext.Groups.Remove(group);
            _uniDbContext.SaveChanges();
        }

        public List<Group> Get()
        {
           return _uniDbContext.Groups.Include(g=>g.Students).Include(g => g.Enrollments).ToList();
        }

        public Group Get(int id)
        {
            return _uniDbContext.Groups.Where(g=>g.GroupId == id).Include(g=>g.Students).Include(g=>g.Enrollments).Single();
        }

        public void SoftDelete(int id)
        {
            var group = _uniDbContext.Groups.Find(id);
            group.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Group group)
        {
            _uniDbContext.Groups.Update(group);
            _uniDbContext.SaveChanges();
        }
    }
}
