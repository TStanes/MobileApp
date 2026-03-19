using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPendingOrder
{
    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedQty { get; set; }

    [Column(TypeName = "decimal(19, 3)")]
    public decimal? PendingOrderQty { get; set; }
}
