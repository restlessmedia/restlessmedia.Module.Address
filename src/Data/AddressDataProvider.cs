using restlessmedia.Module.Data;

namespace restlessmedia.Module.Address.Data
{
  internal class AddressDataProvider : AddressSqlDataProvider, IAddressDataProvider
  {
    public AddressDataProvider(IDataContext context)
      : base(context) { }
  }
}