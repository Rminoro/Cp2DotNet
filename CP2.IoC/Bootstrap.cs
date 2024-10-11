using CP2.Application.Services;
using CP2.Data;
using CP2.Infrastructure.Repositories;
using CP2.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CP2.IoC
{
    public static class Bootstrap
    {
        public static void Start(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationContext>(x => {
                // Resolva a referência a UseOracle corretamente aqui
                x.UseOracle(configuration.GetConnectionString("Oracle"));
            });

            services.AddTransient<IFornecedorRepository, FornecedorRepository>();
            services.AddTransient<IVendedorRepository, VendedorRepository>();
        }
    }
}
