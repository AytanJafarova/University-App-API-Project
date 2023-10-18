using Entities;

namespace DataAccessLayer.Abstract
{
    public interface IAccountRepository
    {
        List<Account> Get();
        Account Get(int id);
        void Add(Account account);
        void Update(Account account);
        void Delete(int id); // Hard Delete
        void SoftDelete(int id); // Soft Delete
    }
}
