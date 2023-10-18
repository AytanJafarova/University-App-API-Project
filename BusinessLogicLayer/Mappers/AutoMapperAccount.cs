using Entities;
using AutoMapper;
using DTO.AccountDTOs;

namespace BusinessLogicLayer.Mappers
{
    public class AutoMapperAccount:Profile
    {
        public AutoMapperAccount()
        {
            CreateMap<AccountToAddDTO, Account>();
            CreateMap<Account, AccountToListDTO>();
            CreateMap<Account, AccountToRelationsDTO>();
            CreateMap<AccountToUpdateDTO, Account>();
        }
    }
}
