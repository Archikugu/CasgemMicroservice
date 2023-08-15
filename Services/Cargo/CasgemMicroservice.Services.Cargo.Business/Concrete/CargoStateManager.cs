﻿using CasgemMicroservice.Services.Cargo.Business.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Abstract;
using CasgemMicroservice.Services.Cargo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.Business.Concrete
{
    public class CargoStateManager : ICargoStateService
    {
        private readonly ICargoStateDal _cargoStateDal;

        public CargoStateManager(ICargoStateDal cargoStateDal)
        {
            _cargoStateDal = cargoStateDal;
        }

        public void TDelete(CargoState entity)
        {
            _cargoStateDal.Delete(entity);
        }

        public List<CargoState> TGetAll()
        {
            return _cargoStateDal.GetAll();
        }

        public CargoState TGetById(int id)
        {
            return _cargoStateDal.GetById(id);
        }

        public void TInsert(CargoState entity)
        {
            _cargoStateDal.Insert(entity);
        }

        public void TUpdate(CargoState entity)
        {
            _cargoStateDal.Update(entity);
        }
    }
}
