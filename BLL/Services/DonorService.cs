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
    public class DonorService
    {
        public static List<DonorDTO> Get()
        {
            var data = DataAccessFactory.DonorDataAccess().Get();
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<Donor, DonorDTO>()
                );
            var mapper = new Mapper(config);
            var Donors = mapper.Map<List<DonorDTO>>(data);
            return Donors;
        }

        public static DonorDTO Get(int id)
        {
            var data = DataAccessFactory.DonorDataAccess().Get(id);
            var config = new MapperConfiguration(
                cfg => cfg.CreateMap<Donor, DonorDTO>()
                );
            var mapper = new Mapper(config);
            var Donors = mapper.Map<DonorDTO>(data);
            return Donors;
        }

        public static DonorDTO Add(DonorDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<Donor, DonorDTO>();
                    cfg.CreateMap<DonorDTO, Donor>();
                });
            var mapper = new Mapper(config);
            var Donor = mapper.Map<Donor>(obj);
            var result = DataAccessFactory.DonorDataAccess().Add(Donor);
            return mapper.Map<DonorDTO>(result);
        }

        public static bool Delete(int id)
        {
            return DataAccessFactory.DonorDataAccess().Delete(id);
        }

        public static bool Update(DonorDTO obj)
        {
            var config = new MapperConfiguration(
                cfg => {
                    cfg.CreateMap<DonorDTO, Donor>();
                });
            var mapper = new Mapper(config);
            var Donor = mapper.Map<Donor>(obj);
            var result = DataAccessFactory.DonorDataAccess().Update(Donor);
            return result;
        }
    }
}
