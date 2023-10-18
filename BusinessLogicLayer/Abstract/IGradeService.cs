using DTO.GradeDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IGradeService
    {
        List<GradeToListDTO> Get();
        GradeToListDTO Get(int id);
        void Add(GradeToAddDTO dto);
        void Update(int id,  GradeToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
        int TotalGrade(GradeToListDTO dto);
    }
}
