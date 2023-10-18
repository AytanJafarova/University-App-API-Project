using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.ExamDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class ExamManager:IExamService
    {
        protected internal IExamRepository _examRepository;
        protected internal IMapper _mapper;

        public ExamManager(IExamRepository examRepository,IMapper mapper)
        {
            _examRepository = examRepository;
            _mapper = mapper;
        }
        public void Add(ExamToAddDTO dto)
        {
            _examRepository.Add(_mapper.Map<Exam>(dto));
        }

        public void Delete(int id)
        {
            _examRepository.Delete(id);
        }

        public List<ExamToListDTO> Get()
        {
            return _mapper.Map<List<ExamToListDTO>>(_examRepository.Get());
        }

        public ExamToListDTO Get(int id)
        {
            return _mapper.Map<ExamToListDTO>(_examRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _examRepository.SoftDelete(id);
        }

        public void Update(int id, ExamToUpdateDTO dto)
        {
            Exam exam = _mapper.Map<Exam>(dto);
            exam.ExamId = id;
            _examRepository.Update(exam);
        }
    }
}
