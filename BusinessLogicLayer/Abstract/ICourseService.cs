using DTO.CourseDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface ICourseService
    {
        List<CourseToListDTO> Get();
        CourseToListDTO Get(int id);
        void Add(CourseToAddDTO dto);
        void Update(int id,  CourseToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
