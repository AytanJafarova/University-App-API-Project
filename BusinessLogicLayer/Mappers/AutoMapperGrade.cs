using Entities;
using AutoMapper;
using DTO.GradeDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperGrade:Profile
    {
        public AutoMapperGrade()
        {
            CreateMap<GradeToAddDTO, Grade>();
            CreateMap<Grade, GradeToListDTO>();
            CreateMap<GradeToUpdateDTO, Grade>();
        }
    }
}
