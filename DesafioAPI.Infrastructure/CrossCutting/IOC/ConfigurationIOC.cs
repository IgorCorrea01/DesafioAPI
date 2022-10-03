using Autofac;
using DesafioAPI.Application;
using DesafioAPI.Application.Interfaces;
using DesafioAPI.Application.Interfaces.Mapper;
using DesafioAPI.Application.Mapper;
using DesafioAPI.Domain.Core.Interfaces.Repository;
using DesafioAPI.Domain.Core.Interfaces.Service;
using DesafioAPI.Domain.Entity;
using DesafioAPI.Domain.Services;
using DesafioAPI.Infrastructure.Data.Repository;

namespace DesafioAPI.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();
            builder.RegisterType<ServiceProduto<Produto>>().As<IServiceProduto<Produto>>();
            builder.RegisterType<RepositoryProduto<Produto>>().As<IRepositoryProduto<Produto>>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();

            #endregion
        }
    }
}
