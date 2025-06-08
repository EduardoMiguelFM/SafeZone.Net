using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using SafeZone.Application.Interfaces;
using SafeZone.Application.Mapping;
using SafeZone.API.Services;
using SafeZone.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar conexão com PostgreSQL
builder.Services.AddDbContext<SafeZoneContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// Injetar AutoMapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

// Injetar serviços
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IAlertaService, AlertaService>();
builder.Services.AddScoped<ILocalizacaoService, LocalizacaoService>();
builder.Services.AddScoped<IAreaSeguraService, AreaSeguraService>();

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "SafeZone API",
        Version = "v1",
        Description = "API REST para gerenciamento de alertas e áreas seguras"
    });
});

var app = builder.Build();

// Ativar Swagger em dev
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "SafeZone API v1");
    });
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
