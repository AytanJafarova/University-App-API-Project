using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.CourseDTOs;
using Entities;

namespace BusinessLogicLayer.Concrete
{
    public class CourseManager : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMapper _mapper;

        public CourseManager(ICourseRepository courseRepository, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _mapper = mapper;
        }
        public void Add(CourseToAddDTO course)
        {
            _courseRepository.Add(_mapper.Map<Course>(course));
        }

        public void Delete(int id)
        {
            _courseRepository.Delete(id);
        }

        public List<CourseToListDTO> Get()
        {
            return _mapper.Map<List<CourseToListDTO>>(_courseRepository.Get());
        }

        public CourseToListDTO Get(int id)
        {
            return _mapper.Map<CourseToListDTO>(_courseRepository.Get(id));
        }

        public void SoftDelete(int id)
        {
            _courseRepository.SoftDelete(id);
        }

        public void Update(int id, CourseToUpdateDTO dto)
        {
            Course course = _mapper.Map<Course>(dto);
            course.CourseId = id;
            _courseRepository.Update(course);
        }
    }
}
