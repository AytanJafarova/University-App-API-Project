using DTO.TeacherDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface ITeacherService
    {
        List<TeacherToListDTO> Get();
        TeacherToListDTO Get(int id);
        void Add(TeacherToAddDTO dto);
        void Update(int id,  TeacherToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
