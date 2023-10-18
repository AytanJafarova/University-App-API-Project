using Entities;
using AutoMapper;
using DTO.TeacherDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperTeacher:Profile
    {
        public AutoMapperTeacher()
        {
            CreateMap<TeacherToAddDTO, Teacher>();
            CreateMap<Teacher, TeacherToListDTO>();
            CreateMap<Teacher, TeacherToDepartmentDTO>();
            CreateMap<TeacherToUpdateDTO, Teacher>();
        }
    }
}
