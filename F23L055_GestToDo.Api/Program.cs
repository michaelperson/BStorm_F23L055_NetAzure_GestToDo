using DR = F23L055_GestToDo.Dal.Repositories;
using DS = F23L055_GestToDo.Dal.Services;

using F23L055_GestToDo.Bll.Repositories;
using F23L055_GestToDo.Bll.Services;
using System.Data.Common;
using System.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);
IConfiguration configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("F23L055_GestToDo")));
builder.Services.AddScoped<DR.ITacheRepository, DS.TacheService>();
builder.Services.AddScoped<ITacheRepository, TacheService>();
builder.Services.AddScoped<DR.IUserDalRepository, DS.UserDalService>();
builder.Services.AddScoped<IUserBllRepository, UserBllService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
