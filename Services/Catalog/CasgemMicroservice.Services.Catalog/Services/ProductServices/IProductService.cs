﻿using CasgemMicroservice.Services.Catalog.Dtos.ProductDtos;
using CasgemMicroservice.Shared.Dtos;

namespace CasgemMicroservice.Services.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProductAsync();
        Task<Response<ResultProductDto>> GetByIdProductAsync(string id);
        Task<Response<NoContent>> CreateProductAsync(CreateProductDto dto);
        Task<Response<NoContent>> UpdateProductAsync(UpdateProductDto dto);
        Task<Response<NoContent>> DeleteProductAsync(string id);
    }
}
