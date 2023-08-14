using AutoMapper;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.AdressDtos;
using CasgemMicroservice.Services.Order.Core.Application.Dtos.OrderDetailDtos;
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
	public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, ResultAdressDto>
	{
		private readonly IRepository<Adress> _repository;
		private readonly IMapper _mapper;

		public GetByIdAddressQueryHandler(IRepository<Adress> repository, IMapper mapper)
		{
			_repository = repository;
			_mapper = mapper;
		}
		public async Task<ResultAdressDto> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
		{
			var result = await _repository.GetByIdAsync(request.Id);
			return _mapper.Map<ResultAdressDto>(result);
		}
	}
}
