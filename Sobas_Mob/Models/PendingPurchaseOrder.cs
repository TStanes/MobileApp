using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("PendingPurchaseOrder")]
public partial class PendingPurchaseOrder
{
    [Column("Name of the Supplier")]
    [StringLength(255)]
    public string? NameOfTheSupplier { get; set; }

    [Column("POno")]
    [StringLength(255)]
    public string? Pono { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Date { get; set; }

    [StringLength(255)]
    public string? Product { get; set; }

    public double? Quantity { get; set; }

    [StringLength(255)]
    public string? Branch { get; set; }

    [Column("Rcd Qty")]
    public double? RcdQty { get; set; }

    [Column("Pending Qty")]
    public double? PendingQty { get; set; }

    [StringLength(255)]
    public string? ItemCategory { get; set; }
}
