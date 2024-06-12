using Microsoft.EntityFrameworkCore;
using PlataformaCursos.API.Extensions;
using PlataformaCursos.Application.Mappers;
using PlataformaCursos.Infra.Persistence;
using PlataformaCursos.Infra.Services;
using Refit;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var connectionString = builder.Configuration.GetConnectionString("DbConnection");
builder.Services.AddDbContext<PlataformaCursosDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddInfrastructure();

builder.Services.AddRefitClient<IAsaasService>().ConfigureHttpClient(c =>
{
    var urlApi = builder.Configuration["AsaasSettings:Url"];
    var token = builder.Configuration["AsaasSettings:Token"];
    c.BaseAddress = new Uri(urlApi!);
    c.DefaultRequestHeaders.Add("access_token", token);
});


builder.Services.SwaggerConfig();

builder.Services.JsonSerializationConfig();

builder.Services.AddAutoMapper(typeof(UserMapper));

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(AppDomain.CurrentDomain.GetAssemblies()));

var key = Encoding.ASCII.GetBytes(builder.Configuration["TokenSettings:Secret"]!);
builder.Services.AuthConfig(key);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

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
