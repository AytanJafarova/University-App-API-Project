using Entities;
using AutoMapper;
using DTO.ExamDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperExam:Profile
    {
        public AutoMapperExam()
        {
            CreateMap<ExamToAddDTO, Exam>();
            CreateMap<Exam, ExamToListDTO>();
            CreateMap<Exam, ExamToCourseDTO>();
            CreateMap<ExamToUpdateDTO, Exam>();
        }
    }
}
