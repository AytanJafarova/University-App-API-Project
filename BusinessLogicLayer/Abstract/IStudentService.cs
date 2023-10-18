using DTO.AccountDTOs;
using DTO.StudentDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IStudentService
    {
        List<StudentToListDTO> Get();
        StudentToListDTO Get(int id);
        void Add(StudentToAddDTO dto);
        void Update(int id,  StudentToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
