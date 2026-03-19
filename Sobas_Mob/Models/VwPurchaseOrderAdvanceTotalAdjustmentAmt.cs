using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPurchaseOrderAdvanceTotalAdjustmentAmt
{
    [Column("PurchaseOrderAdvanceUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseOrderAdvanceUid { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AdjustedAmount { get; set; }
}
