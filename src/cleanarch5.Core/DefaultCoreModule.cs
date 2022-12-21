using Autofac;
using cleanarch5.Core.Interfaces;
using cleanarch5.Core.Services;

namespace cleanarch5.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();
  }
}
