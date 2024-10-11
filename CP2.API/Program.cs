//using CP2.Infrastructure.Repositories; // Ajuste para o namespace correto
//using CP2.Data; // Importando o ApplicationContext
//using CP2.Domain.Interfaces;
//using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Configurar a string de conex�o
//builder.Services.AddDbContext<ApplicationContext>(options =>
//    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"))); // Use Oracle se estiver utilizando Oracle

//// Adicionar servi�os ao cont�iner
//builder.Services.AddControllers();

//// Configura��o do Swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen(c =>
//{
//    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
//    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
//    c.IncludeXmlComments(xmlPath);
//});

//// Configurar reposit�rios e servi�os
//builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
//builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();

//var app = builder.Build();

//// Configure o pipeline de requisi��es HTTP
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI(c =>
//    {
//        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CP2 API v1");
//        c.RoutePrefix = string.Empty; // Faz o Swagger UI aparecer na raiz
//    });
//}

//app.UseAuthorization();
//app.MapControllers();
//app.Run();
using CP2.Infrastructure.Repositories; // Ajuste para o namespace correto
using CP2.Data; // Importando o ApplicationContext
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using CP2.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// Configurar a string de conex�o
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseOracle(builder.Configuration.GetConnectionString("DefaultConnection"))); // Use Oracle se estiver utilizando Oracle

// Adicionar servi�os ao cont�iner
builder.Services.AddControllers();

// Configura��o do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    var xmlFile = $"{System.Reflection.Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    c.IncludeXmlComments(xmlPath);
});

// Configurar reposit�rios e servi�os
builder.Services.AddScoped<IVendedorRepository, VendedorRepository>();
builder.Services.AddScoped<IFornecedorRepository, FornecedorRepository>();
builder.Services.AddScoped<IFornecedorApplicationService, FornecedorApplicationService>(); 


var app = builder.Build();

// Configure o pipeline de requisi��es HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "CP2 API v1");
        c.RoutePrefix = string.Empty;
    });
}

app.UseAuthorization();
app.MapControllers();
app.Run();
