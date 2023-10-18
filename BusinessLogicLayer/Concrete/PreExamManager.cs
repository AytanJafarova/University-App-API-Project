using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.PreExamDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class PreExamManager:IPreExamService
    {
        protected internal IPreExamRepository _preExamRepository;
        protected internal IMapper _mapper;

        public PreExamManager(IPreExamRepository preExamRepository, IMapper mapper)
        {
            _mapper = mapper;
            _preExamRepository = preExamRepository;
        }

        public void Add(PreExamToAddDTO dto)
        {
            _preExamRepository.Add(_mapper.Map<PreExam>(dto));
        }

        public void Delete(int id)
        {
            _preExamRepository.Delete(id);
        }

        public List<PreExamToListDTO> Get()
        {
            return _mapper.Map<List<PreExamToListDTO>>(_preExamRepository.Get());
        }

        public PreExamToListDTO Get(int id)
        {
            return _mapper.Map<PreExamToListDTO>(_preExamRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _preExamRepository.SoftDelete(id);
        }

        public void Update(int id, PreExamToUpdateDTO dto)
        {
            PreExam preExam = _mapper.Map<PreExam>(dto);
            preExam.PreExamId = id;
            _preExamRepository.Update(preExam);
        }
    }
}
