using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwSupVoucherMatchDrTotalAdjustmentReport
{
    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column("DrVoucherUID")]
    public Guid DrVoucherUid { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? AdjustedAmount { get; set; }
}
