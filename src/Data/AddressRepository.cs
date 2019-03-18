using restlessmedia.Module.Data.EF;
using System.Linq;

namespace restlessmedia.Module.Address.Data
{
  internal class AddressRepository : LicensedEntityRepository<VAddress>
  {
    public AddressRepository(DatabaseContext context)
      : base(context)
    {
      _context = context;
    }

    public VAddress Save(IAddress address)
    {
      VAddress dataModel = new VAddress(address);

      if (_context.Data.Any(x => x.AddressId == address.AddressId))
      {
        return Update(dataModel,
          x => x.AddressId,
          x => x.Address01,
          x => x.Address02,
          x => x.Town,
          x => x.City,
          x => x.PostCode,
          x => x.CountryCode,
          x => x.NameNumber,
          x => x.KnownAs,
          x => x.Latitude,
          x => x.Longitude
        );
      }
      else
      {
        return Add(dataModel);
      }
    }

    private readonly DatabaseContext _context;
  }
}