using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AdressDtos;
using CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Queries;
using CasgemMicroservice.Services.Order.Core.Application.Interfaces;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasgemMicroservice.Services.Order.Core.Application.Features.CQRS.Handlers
{
	public class GetAllAddressQueryHandler : IRequestHandler<GetAllAddressQueryRequest, List<ResultAdressDto>>
	{
		private readonly IRepository<Adress> _repository;
		private readonly IMapper _mapper;

		public GetAllAddressQueryHandler(IRepository<Adress> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<List<ResultAdressDto>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
		{
			var values = await _repository.GetAllAsync();
			return _mapper.Map<List<ResultAdressDto>>(values);
		}
	}
}
