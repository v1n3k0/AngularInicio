using Microsoft.Extensions.DependencyInjection;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories.Pedido;
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
            Application(services);
            Domain(services);
            Infra(services);
        }

        private static void Application(IServiceCollection services)
        {

        }

        private static void Domain(IServiceCollection services)
        {

        }

        private static void Infra(IServiceCollection services)
        {
            //Base
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IDbConnection>(x => new System.Data.SqlClient.SqlConnection("Data Source=.;Initial Catalog=DATABASE_NAME;Integrated Security=True;"));
            RegisterMappings.Register();

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
