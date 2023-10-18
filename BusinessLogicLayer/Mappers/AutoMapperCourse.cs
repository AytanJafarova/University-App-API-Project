using Entities;
using AutoMapper;
using DTO.CourseDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperCourse:Profile
    {
        public AutoMapperCourse()
        {
            CreateMap<CourseToAddDTO, Course>();
            CreateMap<Course, CourseToListDTO>();
            CreateMap<CourseToUpdateDTO, Course>();
            CreateMap<Course, CourseToDepartmentDTO>();
            CreateMap<Course, CourseToExamDTO>();
        }
    }
}
