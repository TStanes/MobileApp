using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PurchaseOrderAdvanceAdjustment")]
public partial class PurchaseOrderAdvanceAdjustment
{
    [Key]
    [Column("PurchaseOrderAdvanceAdjustmentUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseOrderAdvanceAdjustmentUid { get; set; }

    [Column("PurchaseOrderAdvanceUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseOrderAdvanceUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("PurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseInvoiceHeaderUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdjustedAmount { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("PurchaseOrderAdvanceUid")]
    [InverseProperty("PurchaseOrderAdvanceAdjustments")]
    public virtual PurchaseOrderAdvance PurchaseOrderAdvanceU { get; set; } = null!;

    [ForeignKey("VoucherHeaderUid")]
    [InverseProperty("PurchaseOrderAdvanceAdjustments")]
    public virtual VoucherHeader VoucherHeaderU { get; set; } = null!;
}
