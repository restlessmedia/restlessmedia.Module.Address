using restlessmedia.Module.Data;
using restlessmedia.Module.Data.EF;
using System.Data.Entity;

namespace restlessmedia.Module.Address.Data
{
  internal class DatabaseContext : DatabaseContext<VAddress>
  {
    public DatabaseContext(IDataContext dataContext, bool autoDetectChanges = false)
      : base(dataContext, autoDetectChanges) { }

    protected override void Configure(DbModelBuilder modelBuilder)
    {
      base.Configure(modelBuilder);

      modelBuilder.Configurations.Add(new LicensedEntityConfiguration<VAddress>());
    }
  }
}