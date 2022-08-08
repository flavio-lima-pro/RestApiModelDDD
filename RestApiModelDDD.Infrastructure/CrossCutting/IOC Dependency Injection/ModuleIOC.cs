using Autofac;

namespace RestApiModelDDD.Infrastructure.CrossCutting.IOC_Dependency_Injection
{
    public class ModuleIOC : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIOC.Load(builder);
        }
    }
}
