using AutoMapper;
using BusinessLogicLayer.Abstract;
using Core.Enums;
using DataAccessLayer.Abstract;
using DTO.AccountDTOs;
using DTO.TeacherDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class TeacherManager:ITeacherService
    {
        protected internal ITeacherRepository _teacherRepository;
        protected internal IMapper _mapper;
        protected internal IAccountRepository _accountRepository;
        public TeacherManager(ITeacherRepository teacherRepository, IMapper mapper, IAccountRepository accountRepository)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
            _accountRepository = accountRepository; 
        }

        public void Add(TeacherToAddDTO dto)
        {
            AccountToAddDTO accountToAdd = new AccountToAddDTO();
            accountToAdd.Username = dto.Account.Username;
            accountToAdd.Password = dto.Account.Password;
            if (accountToAdd.Status != EAccountStatus.teacher)
            {
                accountToAdd.Status = EAccountStatus.teacher;
            }
            var account = _mapper.Map<Account>(accountToAdd);
            var teacher = _mapper.Map<Teacher>(dto);
            _teacherRepository.Add(teacher);
        }

        public void Delete(int id)
        {
            _teacherRepository.Delete(id);
        }

        public List<TeacherToListDTO> Get()
        {
            return _mapper.Map<List<TeacherToListDTO>>(_teacherRepository.Get());
        }

        public TeacherToListDTO Get(int id)
        {
            return _mapper.Map<TeacherToListDTO>(_teacherRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _teacherRepository.SoftDelete(id);
        }

        public void Update(int id, TeacherToUpdateDTO dto)
        {
            Teacher teacher = _mapper.Map<Teacher>(dto);
            teacher.TeacherId = id;
            _teacherRepository.Update(teacher);
        }
    }
}
