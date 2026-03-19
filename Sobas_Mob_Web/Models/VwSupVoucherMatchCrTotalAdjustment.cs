using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwSupVoucherMatchCrTotalAdjustment
{
    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column("CrVoucherUID")]
    public Guid CrVoucherUid { get; set; }

    [Column(TypeName = "decimal(38, 2)")]
    public decimal? AdjustedAmount { get; set; }
}
