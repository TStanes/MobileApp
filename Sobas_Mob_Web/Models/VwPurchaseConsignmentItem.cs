using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwPurchaseConsignmentItem
{
    [Column("PurchaseInvoiceDetailUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceDetailUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }
}
