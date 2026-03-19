using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ProvisionalSchemeCreditNote_temp")]
public partial class ProvisionalSchemeCreditNoteTemp
{
    public Guid ProvisionalSchemeCreditNote { get; set; }

    [Column("GenerationUID")]
    public Guid GenerationUid { get; set; }

    public bool IsExtn { get; set; }

    [Column("CombiID")]
    public int CombiId { get; set; }

    [Column("discountUID")]
    public Guid DiscountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SalesQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal SalesReturnQty { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal SalesValue { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal SalesReturnValue { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal NetValue { get; set; }

    public int? PaidAmount { get; set; }

    public int? PaymentMade { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Percentage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Value { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal CreditNoteValue { get; set; }

    [Column(TypeName = "decimal(38, 6)")]
    public decimal? UpdatedCreditNoteValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreditNoteCheckedBy { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreditNoteApprovedBy { get; set; }

    public bool? IsCreditNoteGenerated { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Createdby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Modifiedby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RejectedValue { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PaymentPercentage { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? PaymentValue { get; set; }

    public bool? IsSendToApproval { get; set; }
}
