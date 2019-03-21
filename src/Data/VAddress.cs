using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace restlessmedia.Module.Address.Data
{
  [Table("VAddress")]
  public class VAddress : LicensedEntity, IAddress
  {
    public VAddress(IAddress address)
    {
      AddressId = address.AddressId;
      Address01 = address.Address01;
      Address02 = address.Address02;
      Town = address.Town;
      City = address.City;
      PostCode = address.PostCode;
      CountryCode = address.CountryCode;
      Marker = address.Marker;
      NameNumber = address.NameNumber;
      KnownAs = address.KnownAs;
      Latitude = address.Marker != null && address.Marker.Latitude != 0 ? address.Marker.Latitude : null;
      Longitude = address.Marker != null && address.Marker.Longitude != 0 ? address.Marker.Longitude : null;
    }

    public VAddress()
    {
      Marker = new Marker();
    }

    [Key]
    public int? AddressId { get; set; }

    public string Address01 { get; set; }

    public string Address02 { get; set; }

    public string Town { get; set; }

    public string City { get; set; }

    public string PostCode { get; set; }

    public string CountryCode { get; set; }

    public double? Latitude
    {
      get
      {
        return Marker.Latitude;
      }
      set
      {
        Marker.Latitude = value;
      }
    }

    public double? Longitude
    {
      get
      {
        return Marker.Longitude;
      }
      set
      {
        Marker.Longitude = value;
      }
    }

    public string NameNumber { get; set; }

    public string KnownAs { get; set; }

    [NotMapped]
    public Marker Marker { get; set; }

    public override EntityType EntityType
    {
      get
      {
        return EntityType.Address;
      }
    }

    public override int? EntityId
    {
      get
      {
        return AddressId;
      }
    }

    [NotMapped]
    public override string Title
    {
      get
      {
        return KnownAs;
      }
      set
      {
        KnownAs = value;
      }
    }
  }
}