using CasgemMicroservice.Services.Cargo.Business.Abstract;
using CasgemMicroservice.Services.Cargo.Business.Concrete;
using CasgemMicroservice.Services.Cargo.DataAccess.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccess.Context;
using CasgemMicroservice.Services.Cargo.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("sub");

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "resource_cargo";
    opt.RequireHttpsMetadata = false;
});

builder.Services.AddDbContext<CargoContext>();

builder.Services.AddScoped<ICargoDetailService, CargoDetailManager>();
builder.Services.AddScoped<ICargoDetailDal, EfCargoDetailDal>();

builder.Services.AddScoped<ICargoStateService, CargoStateManager>();
builder.Services.AddScoped<ICargoStateDal, EfCargoStateDal>();

builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
