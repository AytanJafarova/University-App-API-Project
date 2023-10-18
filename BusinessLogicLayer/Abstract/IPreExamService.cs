using DTO.PreExamDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IPreExamService
    {
        List<PreExamToListDTO> Get();
        PreExamToListDTO Get(int id);
        void Add(PreExamToAddDTO dto);
        void Update(int id,  PreExamToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
