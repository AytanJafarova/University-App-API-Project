using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.AccountDTOs;
using Entities;


namespace BusinessLogicLayer.Concrete
{
    public class AccountManager:IAccountService
    {
        protected internal IAccountRepository _accountRepository;
        protected internal IMapper _mapper;
        public AccountManager(IAccountRepository accountRepository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _mapper = mapper;
        }

        public void Add(AccountToAddDTO dto)
        {
            _accountRepository.Add(_mapper.Map<Account>(dto));
        }

        public void Delete(int id)
        {
            _accountRepository.Delete(id);
        }

        public List<AccountToListDTO> Get()
        {
            return _mapper.Map<List<AccountToListDTO>>(_accountRepository.Get());
        }

        public AccountToListDTO Get(int id)
        {
            return _mapper.Map<AccountToListDTO>(_accountRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _accountRepository.SoftDelete(id);
        }

        public void Update(int id, AccountToUpdateDTO dto)
        {
            Account account = _mapper.Map<Account>(dto);
            account.AccountId = id;
            _accountRepository.Update(account);
        }
    }
}
