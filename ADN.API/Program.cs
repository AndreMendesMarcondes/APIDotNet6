using ADN.Data.Repositorio;
using ADN.Domain.DTO.Settings;
using ADN.Domain.Interfaces.Repositorio;
using ADN.Domain.Interfaces.Services;
using ADN.Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.Configure<MongoDBEstudanteSettings>(
    builder.Configuration.GetSection("MongoDBEstudanteSettings"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IEstudanteService, EstudanteService>();
builder.Services.AddScoped<IEstudanteRepositorio, EstudanteRepositorio>();

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
