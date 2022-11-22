using AutoMapper;
using BLL.DTO;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            var data = DataAccessFactory.UserDataAccess().Get();
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<User, UserDTO>()
                );
            var mapper = new Mapper(config);
            var Users = mapper.Map<List<UserDTO>>(data);
            return Users;
        }

        public static UserDTO Get(string id)
        {
            var data = DataAccessFactory.UserDataAccess().Get(id);
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<User, UserDTO>()
                );
            var mapper = new Mapper(config);
            var Users = mapper.Map<UserDTO>(data);
            return Users;
        }

        public static UserDTO Add(UserDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<User, UserDTO>();
                    cfg.CreateMap<UserDTO, User>();
                });
            var mapper = new Mapper(config);
            var User = mapper.Map<User>(obj);
            var result = DataAccessFactory.UserDataAccess().Add(User);
            return mapper.Map<UserDTO>(result);
        }

        public static bool Delete(string id)
        {
            return DataAccessFactory.UserDataAccess().Delete(id);
        }

        public static bool Update(UserDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<UserDTO, User>();
                });
            var mapper = new Mapper(config);
            var User = mapper.Map<User>(obj);
            var result = DataAccessFactory.UserDataAccess().Update(User);
            return result;
        }
    }
}
