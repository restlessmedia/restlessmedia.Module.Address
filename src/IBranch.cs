﻿namespace restlessmedia.Module.Address
{
  public interface IBranch
  {
    int BranchGuid { get; set; }

    int BranchId { get; set; }

    string Name { get; set; }

    byte Type { get; set; }

    string Reference { get; set; }
  }
}