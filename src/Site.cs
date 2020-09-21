namespace restlessmedia.Module.Address
{
  public class Site
  {
    public Site()
    {
      Active = true;
    }

    public AddressEntity Address { get; set; }

    public Marker[] Markers { get; set; }

    public bool Active { get; set; }
  }
}