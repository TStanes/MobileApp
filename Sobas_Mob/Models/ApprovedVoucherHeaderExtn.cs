using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ApprovedVoucherHeaderExtn")]
[Index("CreatedDate", "ModifiedDate", Name = "IX__CreDateModDate")]
public partial class ApprovedVoucherHeaderExtn
{
    [Key]
    [Column("ApprovedVoucherHeaderUID")]
    public Guid ApprovedVoucherHeaderUid { get; set; }

    [Column("RefPurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? RefPurchaseInvoiceHeaderUid { get; set; }

    [Column("RefInventoryServiceTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefInventoryServiceTransUid { get; set; }

    [Column("DepartmentalDivisionUID")]
    public Guid? DepartmentalDivisionUid { get; set; }

    [Column("ITSectionUID")]
    public Guid? ItsectionUid { get; set; }

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

    [Column("DiscountUID")]
    public Guid? DiscountUid { get; set; }

    [Column("IsIBT")]
    public bool? IsIbt { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid? DivisionPrincipleUid { get; set; }
}
