using Autofac;
using NlayerProject.Core.Repositories.Common;
using NlayerProject.Core.Services.Common;
using NlayerProject.Core.UnitOfWorks;
using NlayerProject.Repository.Context;
using NlayerProject.Repository.Repositories.Common;
using NlayerProject.Repository.UnitOfWorks;
using NlayerProject.Service.Mapping;
using NlayerProject.Service.Services.Common;
using System.Reflection;
using Module = Autofac.Module;


namespace NlayerProject.API.Modules
{
    public class RepoServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>))
                .As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>))
                .InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly     = Assembly.GetExecutingAssembly();
            var repoAssembly    = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Repository"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly)
                .Where(x => x.Name.EndsWith("Service"))
                .AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
