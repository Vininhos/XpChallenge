using Xp.Infra.Repositories;
using Xp.Services.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

void RegisterDependencies(IServiceCollection services)
{
    services.AddScoped<IClienteRepository, ClienteRepository>();
    services.AddScoped<ICorretoraRepository, CorretoraRepository>();

    services.AddScoped<ClienteService>();
    services.AddScoped<CorretoraService>();
}

RegisterDependencies(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
