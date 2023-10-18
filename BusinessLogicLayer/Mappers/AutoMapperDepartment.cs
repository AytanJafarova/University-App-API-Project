using Entities;
using DTO.DepartmentDTOs;
using AutoMapper;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperDepartment:Profile
    {
        public AutoMapperDepartment()
        {
            CreateMap<DepartmentToAddDTO, Department>();
            CreateMap<Department, DepartmentToListDTO>();
            CreateMap<Department, DepartmentToRelationsDTO>();
            CreateMap<DepartmentToUpdateDTO, Department>();
            CreateMap<Department, DepartmentToCourseDTO>();
        }
    }
}
