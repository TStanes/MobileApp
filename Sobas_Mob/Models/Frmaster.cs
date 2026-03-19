using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("FRMaster")]
public partial class Frmaster
{
    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    [StringLength(255)]
    public string? ItemCode { get; set; }

    [StringLength(255)]
    public string? ItemDesc { get; set; }

    public double? Freight { get; set; }

    public bool IsActive { get; set; }
}
