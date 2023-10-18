using DTO.EnrollmentDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IEnrollmentService
    {
        List<EnrollmentToListDTO> Get();
        EnrollmentToListDTO Get(int id);
        void Add(EnrollmentToAddDTO dto);
        void Update(int id,  EnrollmentToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
