using CasgemMicroservice.Services.Cargo.DataAccess.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Context;
using CasgemMicroservice.Services.Cargo.DataAccess.Repositories;
using CasgemMicroservice.Services.Cargo.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Cargo.DataAccess.EntityFramework
{
    public class EfCargoDetailDal : GenericRepository<CargoDetail>, ICargoDetailDal
    {
        public EfCargoDetailDal(CargoContext context) : base(context)
        {

        }
    }
}
