using Autofac;
using RestApiModelDDD.Application;
using RestApiModelDDD.Application.Interfaces;
using RestApiModelDDD.Application.Interfaces.IMapping;
using RestApiModelDDD.Application.Mapping;
using RestApiModelDDD.Domain.Core.Interfaces.Repositories;
using RestApiModelDDD.Domain.Core.Interfaces.Services;
using RestApiModelDDD.Domain.Services;
using RestApiModelDDD.Infrastructure.Data.Repositories;

namespace RestApiModelDDD.Infrastructure.CrossCutting.IOC_Dependency_Injection
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region

            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceCliente>().As<IServiceCliente>();
            builder.RegisterType<ServiceProduto>().As<IServiceProduto>();
            builder.RegisterType<RepositoryCliente>().As<IRepositoryCliente>();
            builder.RegisterType<RepositoryProduto>().As<IRepositoryProduto>();
            builder.RegisterType<MappingCliente>().As<IMappingCliente>();
            builder.RegisterType<MappingProduto>().As<IMappingProduto>();

            #endregion
        }
    }
}
