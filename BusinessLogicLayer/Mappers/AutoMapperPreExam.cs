using Entities;
using AutoMapper;
using DTO.PreExamDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperPreExam:Profile
    {
        public AutoMapperPreExam()
        {
            CreateMap<PreExamToAddDTO, PreExam>();
            CreateMap<PreExam, PreExamToListDTO>();
            CreateMap<PreExam, PreExamToRelationsDTO>();
            CreateMap<PreExamToUpdateDTO, PreExam>();
        }
    }
}
