using restlessmedia.Module.Data;
using restlessmedia.Module.Data.Sql;

namespace restlessmedia.Module.Address.Data
{
  internal class AddressSqlDataProvider : SqlDataProviderBase
  {
    public AddressSqlDataProvider(IDataContext context)
      : base(context) { }

    public void Save(IAddress address)
    {
      using (DatabaseContext context = new DatabaseContext(DataContext))
      {
        AddressRepository repository = new AddressRepository(context);
        VAddress dataModel = repository.Save(address);

        context.SaveChanges();

        if (!address.AddressId.HasValue)
        {
          address.AddressId = dataModel.AddressId;
        }
      }
    }
  }
}