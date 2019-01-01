using Unity;
using Unity.Lifetime;
using Whisp.Application.Configuration;
using Whisp.Application.Interfaces;
using Whisp.Application.Interfaces.Repositories;
using Whisp.Application.Interfaces.Services;
using Whisp.Application.Services;
using Whisp.Infrastructure;
using Whisp.Infrastructure.Repositories;
using Whisp.Persistence;

namespace Whisp.Api.Resolver.Containers
{
    public class ApplicationContainer
    {
        public ApplicationContainer()
        {
        }

        public UnityContainer Get()
        {
            var container = new UnityContainer();
            container.RegisterType<IAppLogger, AppLogger>(new HierarchicalLifetimeManager());
            container.RegisterType<IVehicleService, VehicleService>(new HierarchicalLifetimeManager());
            container.RegisterType<IVehicleRepository, VehicleRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDatabase, MySqlDatabase>(new HierarchicalLifetimeManager());
            container.RegisterType<IConfig, Config>(new HierarchicalLifetimeManager());
            return container;
        }
    }
}