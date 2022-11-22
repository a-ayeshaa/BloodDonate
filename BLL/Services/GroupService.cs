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
    public class GroupService
    {
        public static List<GroupDTO> Get()
        {
            var data = DataAccessFactory.GroupDataAccess().Get();
            var config=new MapperConfiguration(
                cfg=>cfg.CreateMap<Group,GroupDTO>()
                );
            var mapper = new Mapper(config);
            var groups = mapper.Map<List<GroupDTO>>(data);
            return groups;
        }

        public static GroupDTO Get(int id)
        {
            var data = DataAccessFactory.GroupDataAccess().Get(id);
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<Group, GroupDTO>()
                );
            var mapper = new Mapper(config);
            var groups = mapper.Map<GroupDTO>(data);
            return groups;
        }

        public static GroupDTO Add(GroupDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<Group, GroupDTO>();
                    cfg.CreateMap<GroupDTO, Group>();
                });
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(obj);
            var result = DataAccessFactory.GroupDataAccess().Add(group);
            return mapper.Map<GroupDTO>(result);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.GroupDataAccess().Delete(id);
        }

        public static bool Update(GroupDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<GroupDTO, Group>();
                });
            var mapper = new Mapper(config);
            var group = mapper.Map<Group>(obj);
            var result = DataAccessFactory.GroupDataAccess().Update(group);
            return result;
        }
    }
}
