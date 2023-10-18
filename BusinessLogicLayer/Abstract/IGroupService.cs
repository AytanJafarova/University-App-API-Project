using DTO.GroupDTOs;

namespace BusinessLogicLayer.Abstract
{
    public interface IGroupService
    {
        List<GroupToListDTO> Get();
        GroupToListDTO Get(int id);
        void Add(GroupToAddDTO dto);
        void Update(int id,  GroupToUpdateDTO dto);
        void Delete(int id);
        void SoftDelete(int id);
    }
}
