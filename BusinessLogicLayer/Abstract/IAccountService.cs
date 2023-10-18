using DTO.AccountDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IAccountService
    {
        List<AccountToListDTO> Get();
        AccountToListDTO Get(int id);
        void Add(AccountToAddDTO dto);
        void Update(int id,  AccountToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
