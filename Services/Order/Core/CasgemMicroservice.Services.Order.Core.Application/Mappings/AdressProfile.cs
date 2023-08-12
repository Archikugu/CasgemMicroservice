using CasgemMicroservice.Services.Order.Core.Application.Dtos.AdressDtos;
using CasgemMicroservice.Services.Order.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CasgemMicroservice.Services.Order.Core.Application.Mappings
{
	public class AdressProfile : Profile
	{
		public AdressProfile()
		{
			CreateMap<ResultAdressDto, Adress>().ReverseMap();
			CreateMap<CreateAdressDto, Adress>().ReverseMap();
			CreateMap<UpdateAdressDto, Adress>().ReverseMap();
		}
	}
}
