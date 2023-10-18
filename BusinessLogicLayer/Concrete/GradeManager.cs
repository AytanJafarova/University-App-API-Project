using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.GradeDTOs;
using Entities;


namespace BusinessLogicLayer.Concrete
{
    public class GradeManager : IGradeService
    {
        protected internal IGradeRepository _gradeRepository;
        protected internal IMapper _mapper;

        public GradeManager(IGradeRepository gradeRepository, IMapper mapper)
        {
            _gradeRepository = gradeRepository;
            _mapper = mapper;
        }

        public void Add(GradeToAddDTO dto)
        {
            _gradeRepository.Add(_mapper.Map<Grade>(dto));  
        }

        public void Delete(int id)
        {
            _gradeRepository.Delete(id);
        }

        public List<GradeToListDTO> Get()
        {
            return _mapper.Map<List<GradeToListDTO>>(_gradeRepository.Get());
        }

        public GradeToListDTO Get(int id)
        {
            return _mapper.Map<GradeToListDTO>(_gradeRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
           _gradeRepository.SoftDelete(id);
        }

        public int TotalGrade(GradeToListDTO dto)
        {
            return _gradeRepository.TotalGrade(_mapper.Map<Grade>(dto));
        }

        public void Update(int id, GradeToUpdateDTO dto)
        {
            Grade grade = _mapper.Map<Grade>(dto);
            grade.GradeId = id;
            _gradeRepository.Update(grade); 
        }
    }
}
