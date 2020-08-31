using Microsoft.Extensions.DependencyInjection;
using PassaroUrbano.Application.AppServices.Oferta;
using PassaroUrbano.Application.Interfaces.Oferta;
using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using PassaroUrbano.Domain.Interfaces.Domain.Pedido;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories.Pedido;
using PassaroUrbano.Domain.Services.Oferta;
using PassaroUrbano.Domain.Services.Pedido;
using PassaroUrbano.Infra.Data;
using PassaroUrbano.Infra.Data.Repositories;
using PassaroUrbano.Infra.Data.Repositories.Oferta;
using PassaroUrbano.Infra.Data.Repositories.Pedido;
using System.Data;

namespace PassaroUrbano.Infra.IoC
{
    public static class BootStrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            Infra(services);
            Domain(services);
            Application(services);
        }

        private static void Application(IServiceCollection services)
        {
            //Oferta
            services.AddTransient<IOfertaAppService, OfertaAppService>();
        }

        private static void Domain(IServiceCollection services)
        {
            //Oferta
            services.AddTransient<IOfertaService, OfertaService>();

            //Pedido
            services.AddTransient<IPedidoService, PedidoService>();
        }

        private static void Infra(IServiceCollection services)
        {
            //Base
            RegisterMappings.Register();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDbConnection>(x => new System.Data.SqlClient.SqlConnection("Server=localhost\\SQLEXPRESS;Database=passaro;Trusted_Connection=True;"));

            //Oferta
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<IComoUsarRepository, ComoUsarRepository>();
            services.AddTransient<IImagemRepository, ImagemRepository>();
            services.AddTransient<IOfertaRepository, OfertaRepository>();
            services.AddTransient<IOndeFicaRepository, OndeFicaRepository>();

            //Pedido
            services.AddTransient<IPedidoRepository, PedidoRepository>();
        }
    }
}
