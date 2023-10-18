using Entities;
using AutoMapper;
using DTO.GroupDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperGroup:Profile
    {
        public AutoMapperGroup()
        {
            CreateMap<GroupToAddDTO, Group>();
            CreateMap<Group, GroupToListDTO>();
            CreateMap<Group, GroupToStudentDTO>();
            CreateMap<GroupToUpdateDTO, Group>();
        }
    }
}
