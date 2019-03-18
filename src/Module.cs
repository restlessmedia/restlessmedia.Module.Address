using Autofac;
using restlessmedia.Module.Address.Data;

namespace restlessmedia.Module.Address
{
  public class Module : IModule
  {
    public void RegisterComponents(ContainerBuilder containerBuilder)
    {
      containerBuilder.RegisterType<AddressDataProvider>().As<IAddressDataProvider>().SingleInstance();
    }
  }
}