using CasgemMicroservice.Services.Cargo.DataAccess.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Context;
using CasgemMicroservice.Services.Cargo.DataAccess.Repositories;
using CasgemMicroservice.Services.Cargo.Entities.Entities;

namespace CasgemMicroservice.Services.Cargo.DataAccess.EntityFramework
{
    public class EfCargoStateDal : GenericRepository<CargoState>, ICargoStateDal
    {
        public EfCargoStateDal(CargoContext context) : base(context)
        {
            
        }
    }
}
