using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PurchaseOrderAdvance")]
public partial class PurchaseOrderAdvance
{
    [Key]
    [Column("PurchaseOrderAdvanceUID", TypeName = "decimal(18, 0)")]
    public decimal PurchaseOrderAdvanceUid { get; set; }

    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PoheaderUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdvanceAmount { get; set; }

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

    [InverseProperty("PurchaseOrderAdvanceU")]
    public virtual ICollection<PurchaseOrderAdvanceAdjustment> PurchaseOrderAdvanceAdjustments { get; set; } = new List<PurchaseOrderAdvanceAdjustment>();
}
