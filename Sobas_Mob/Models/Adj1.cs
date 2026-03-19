using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("adj1")]
public partial class Adj1
{
    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? Morethan10days { get; set; }

    public double? Within10Days { get; set; }

    public double? GrandTotal { get; set; }

    [StringLength(255)]
    public string? F6 { get; set; }

    public double? F7 { get; set; }
}
