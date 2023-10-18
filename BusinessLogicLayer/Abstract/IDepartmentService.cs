using DTO.DepartmentDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IDepartmentService
    {
        List<DepartmentToListDTO> Get();
        DepartmentToListDTO Get(int id);
        void Add(DepartmentToAddDTO dto);
        void Update(int id,  DepartmentToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
