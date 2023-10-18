using DTO.ExamDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IExamService
    {
        List<ExamToListDTO> Get();
        ExamToListDTO Get(int id);
        void Add(ExamToAddDTO dto);
        void Update(int id,  ExamToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
