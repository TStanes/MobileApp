using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ClosingQtyTemp
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Receipts { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Issues { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ClosingQty { get; set; }
}
