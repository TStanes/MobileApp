using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempRFCSalesData")]
public partial class TempRfcsalesDatum
{
    [Column("FMonth")]
    public DateOnly? Fmonth { get; set; }

    [Column("FYear")]
    public int? Fyear { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(38, 5)")]
    public decimal? SalesQty { get; set; }
}
