using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VoucherHeaderExtn")]
[Index("DivisionPrincipleUid", "VoucherHeaderUid", Name = "_dta_index_VoucherHeaderExtn_7_128055542__K15_K1")]
[Index("VoucherHeaderUid", "DivisionPrincipleUid", Name = "_dta_index_VoucherHeaderExtn_7_128055542__K1_K15")]
[Index("VoucherHeaderUid", "RefPurchaseInvoiceHeaderUid", Name = "_dta_index_VoucherHeaderExtn_7_128055542__K1_K2")]
[Index("CreatedDate", Name = "_dta_index_VoucherHeaderExtn_7_128055542__K8")]
public partial class VoucherHeaderExtn
{
    [Key]
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

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
