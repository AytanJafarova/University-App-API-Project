using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.EnrollmentDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class EnrollmentManager:IEnrollmentService
    {
        protected internal IEnrollmentRepository _enrollmentRepository;
        protected internal IMapper _mapper;

        public EnrollmentManager(IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _enrollmentRepository = enrollmentRepository;
            _mapper = mapper;
        }

        public void Add(EnrollmentToAddDTO dto)
        {
            _enrollmentRepository.Add(_mapper.Map<Enrollment>(dto));
        }

        public void Delete(int id)
        {
            _enrollmentRepository.Delete(id);
        }

        public List<EnrollmentToListDTO> Get()
        {
            return _mapper.Map<List<EnrollmentToListDTO>>(_enrollmentRepository.Get());
        }

        public EnrollmentToListDTO Get(int id)
        {
            return _mapper.Map<EnrollmentToListDTO>(_enrollmentRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _enrollmentRepository.SoftDelete(id);
        }

        public void Update(int id, EnrollmentToUpdateDTO dto)
        {
            Enrollment enrollment = _mapper.Map<Enrollment>(dto);
            enrollment.EnrollmentId = id;
            _enrollmentRepository.Update(enrollment);
        }
    }
}
