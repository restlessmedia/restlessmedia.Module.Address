using restlessmedia.Module.Data;

namespace restlessmedia.Module.Address.Data
{
  public interface IAddressDataProvider : IDataProvider
  {
    void Save(IAddress address);
  }
}
