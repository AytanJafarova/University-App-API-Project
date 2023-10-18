using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.DepartmentDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        private readonly IMapper _mapper;

        public DepartmentManager(IDepartmentRepository departmentRepository, IMapper mapper)
        {
            _departmentRepository = departmentRepository;
            _mapper = mapper;
        }
        public void Add(DepartmentToAddDTO department)
        {
            _departmentRepository.Add(_mapper.Map<Department>(department));
        }

        public void Delete(int id)
        {
            _departmentRepository.Delete(id);
        }

        public List<DepartmentToListDTO> Get()
        {
            return _mapper.Map<List<DepartmentToListDTO>>(_departmentRepository.Get());
        }

        public DepartmentToListDTO Get(int id)
        {
            return _mapper.Map<DepartmentToListDTO>(_departmentRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _departmentRepository.SoftDelete(id);
        }

        public void Update(int id, DepartmentToUpdateDTO dto)
        {
            Department department = _mapper.Map<Department>(dto);
            department.DepartmentId = id;
            _departmentRepository.Update(department);
        }
    }
}
