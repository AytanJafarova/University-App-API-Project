using Entities;
using AutoMapper;
using DTO.StudentDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperStudent:Profile
    {
        public AutoMapperStudent()
        {
            CreateMap<StudentToAddDTO, Student>();
            CreateMap<Student, StudentToListDTO>();
            CreateMap<Student, StudentToGroupDTO>();
            CreateMap<StudentToUpdateDTO, Student>();
        }
    }
}
