using AutoMapper;
using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using DTO.GroupDTOs;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class GroupManager:IGroupService
    {
        protected internal IGroupRepository _groupRepository { get; set; }
        protected internal IMapper _mapper { get; set; }
        public GroupManager(IGroupRepository groupRepository, IMapper mapper)
        {
            _groupRepository = groupRepository;
            _mapper = mapper;
        }

        public List<GroupToListDTO> Get()
        {
            return _mapper.Map<List<GroupToListDTO>>(_groupRepository.Get());
        }

        public GroupToListDTO Get(int id)
        {
            return _mapper.Map<GroupToListDTO>(_groupRepository.Get(id));
        }

        public void Add(GroupToAddDTO dto)
        {
            _groupRepository.Add(_mapper.Map<Group>(dto));
        }

        public void Update(int id, GroupToUpdateDTO dto)
        {
           Group group = _mapper.Map<Group>(dto);
            group.GroupId = id;
            _groupRepository.Update(group);
        }

        public void Delete(int id)
        {
            _groupRepository.Delete(id);
        }

        public void SoftDelete(int id)
        {
            _groupRepository.SoftDelete(id);
        }
    }
}
