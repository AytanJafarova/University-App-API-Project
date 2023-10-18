using AutoMapper;
using BusinessLogicLayer.Abstract;
using Core.Enums;
using DataAccessLayer.Abstract;
using DTO.AccountDTOs;
using DTO.StudentDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class StudentManager : IStudentService
    {
        protected internal IStudentRepository _studentRepository;
        protected internal IAccountRepository _accountRepository;
        protected internal IMapper _mapper;
        public StudentManager(IStudentRepository studentRepository, IMapper mapper, IAccountRepository accountRepository)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
            _accountRepository = accountRepository;
        }

        public void Add(StudentToAddDTO dto)
        {
            AccountToAddDTO accountToAdd = new AccountToAddDTO();
            accountToAdd.Username = dto.Account.Username;
            accountToAdd.Password = dto.Account.Password;
            if(accountToAdd.Status != EAccountStatus.student)
            {
                accountToAdd.Status = EAccountStatus.student;
            }

            var account = _mapper.Map<Account>(accountToAdd);
            var student = _mapper.Map<Student>(dto);
            _studentRepository.Add(student);
        }
        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public List<StudentToListDTO> Get()
        {
            return _mapper.Map<List<StudentToListDTO>>(_studentRepository.Get());
        }

        public StudentToListDTO Get(int id)
        {
            return _mapper.Map<StudentToListDTO>(_studentRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _studentRepository.SoftDelete(id);
        }

        public void Update(int id, StudentToUpdateDTO dto)
        {
            Student student = _mapper.Map<Student>(dto);
            student.StudentId = id;
            _studentRepository.Update(student);
        }
    }
}
