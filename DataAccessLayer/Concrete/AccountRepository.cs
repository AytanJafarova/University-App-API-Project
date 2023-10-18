using DataAccessLayer.Abstract;
using DataAccessLayer.UniversityDbContext;
using Entities;

namespace DataAccessLayer.Concrete
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UniDbContext _uniDbContext;
        public AccountRepository(UniDbContext uniDbContext)
        {
            _uniDbContext  = uniDbContext;
        }
        public void Add(Account account)
        {
            _uniDbContext.Accounts.Add(account);
            _uniDbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var account = _uniDbContext.Accounts.Find(id);
            _uniDbContext.Accounts.Remove(account);
            _uniDbContext.SaveChanges();
        }

        public List<Account> Get()
        {
           return _uniDbContext.Accounts.ToList();
        }

        public Account Get(int id)
        {
            return _uniDbContext.Accounts.Find(id);
        }

        public void SoftDelete(int id)
        {
            var account = _uniDbContext.Accounts.Find(id);
            account.IsDeleted = true;
            _uniDbContext.SaveChanges();
        }

        public void Update(Account account)
        {
            _uniDbContext.Accounts.Update(account);
            _uniDbContext.SaveChanges();
        }
    }
}
