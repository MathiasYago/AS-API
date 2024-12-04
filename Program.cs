using Microsoft.EntityFrameworkCore;
using AsAPI.Data;
using AsAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Configurar o banco de dados SQLite
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

// Registrar os repositórios no container de injeção de dependência
builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();

// Adicionar os controladores da API
builder.Services.AddControllers();

var app = builder.Build();

// Configurar o middleware da aplicação
app.UseAuthorization();
app.MapControllers();

app.Run();

builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
