using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class BiProductRate
{
    [Column("BiProductRatesUID")]
    public Guid? BiProductRatesUid { get; set; }

    [Column("month")]
    public int Month { get; set; }

    public int Year { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }
}
