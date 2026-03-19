using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProdSumTest")]
public partial class ProdSumTest
{
    [Column("branchcode")]
    public double? Branchcode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    public double? CountQty { get; set; }

    public double? SumNetqty { get; set; }
}
