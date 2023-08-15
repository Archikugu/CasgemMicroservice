using CasgemMicroservice.Services.Cargo.Business.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Context;
using CasgemMicroservice.Services.Cargo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.Business.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        ICargoDetailDal _cargoDetailDal;

        public CargoDetailManager(ICargoDetailDal cargoDetailDal)
        {
            _cargoDetailDal = cargoDetailDal;
        }

        public void TDelete(CargoDetail entity)
        {
            _cargoDetailDal.Delete(entity);
        }

        public List<CargoDetail> TGetAll()
        {
            return _cargoDetailDal.GetAll();
        }

        public CargoDetail TGetById(int id)
        {
            return _cargoDetailDal.GetById(id);
        }

        public void TInsert(CargoDetail entity)
        {
            _cargoDetailDal.Insert(entity);
        }

        public void TUpdate(CargoDetail entity)
        {
            _cargoDetailDal.Update(entity);
        }
    }
}
