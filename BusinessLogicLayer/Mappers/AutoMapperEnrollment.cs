using Entities;
using AutoMapper;
using DTO.EnrollmentDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperEnrollment:Profile
    {
        public AutoMapperEnrollment()
        {
            CreateMap<EnrollmentToAddDTO, Enrollment>();
            CreateMap<Enrollment, EnrollmentToListDTO>();
            CreateMap<Enrollment, EnrollmentToRelationsDTO>();
            CreateMap<EnrollmentToUpdateDTO, Enrollment>();
        }
    }
}
