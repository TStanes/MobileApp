using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Branch_MasterData")]
public partial class BranchMasterDatum
{
    [Column("BranchUID")]
    [StringLength(255)]
    public string? BranchUid { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? BranchCode { get; set; }

    [Column("Address1 for Name ")]
    [StringLength(255)]
    public string? Address1ForName { get; set; }

    [StringLength(255)]
    public string? Address2 { get; set; }

    [Column("Address3 for address 1")]
    [StringLength(255)]
    public string? Address3ForAddress1 { get; set; }

    [Column("Address4  for address 2")]
    [StringLength(255)]
    public string? Address4ForAddress2 { get; set; }

    [StringLength(255)]
    public string? City { get; set; }

    [StringLength(255)]
    public string? Attribute2 { get; set; }

    public double? PinCode { get; set; }

    [StringLength(255)]
    public string? Licence1 { get; set; }

    [StringLength(255)]
    public string? Licence2 { get; set; }

    [StringLength(255)]
    public string? Phone { get; set; }
}
