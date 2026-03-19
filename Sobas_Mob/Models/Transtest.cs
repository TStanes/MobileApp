using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Transtest")]
public partial class Transtest
{
    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? Cancelled { get; set; }

    public double? Active { get; set; }

    public double? Total { get; set; }
}
