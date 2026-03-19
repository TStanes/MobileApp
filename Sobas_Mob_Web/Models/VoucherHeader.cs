using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("VoucherHeader")]
public partial class VoucherHeader
{
    [Key]
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Details { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StatementNo { get; set; }

    [Column("PCRNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Pcrno { get; set; }

    [Column("PCRDate", TypeName = "datetime")]
    public DateTime? Pcrdate { get; set; }

    [Column("DebitBranchUID")]
    public Guid? DebitBranchUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [Column("RefVoucherUID")]
    public Guid? RefVoucherUid { get; set; }

    [Column("StatusUID")]
    public Guid? StatusUid { get; set; }

    [Column("PayModeUID", TypeName = "decimal(18, 0)")]
    public decimal? PayModeUid { get; set; }

    [Column("ChequeorDDNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeorDdno { get; set; }

    [Column("ChequeorDDDate", TypeName = "datetime")]
    public DateTime? ChequeorDddate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionDetails { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReferenceDate { get; set; }

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ChallanNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChallanDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DepositedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RealisationDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? State { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? RejectionReason { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PrincipalCreditNoteNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PrincipalCreditNoteDt { get; set; }

    [Column("HORefNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? HorefNo { get; set; }

    [Column("HORefDt", TypeName = "datetime")]
    public DateTime? HorefDt { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DebitNoteNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DebitNoteDt { get; set; }

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

    [InverseProperty("VoucherHeaderU")]
    public virtual ICollection<EjvvoucherUpdation> EjvvoucherUpdations { get; set; } = new List<EjvvoucherUpdation>();

    [ForeignKey("PayModeUid")]
    [InverseProperty("VoucherHeaders")]
    public virtual PayModeM? PayModeU { get; set; }

    [InverseProperty("VoucherHeaderU")]
    public virtual ICollection<PurchaseOrderAdvanceAdjustment> PurchaseOrderAdvanceAdjustments { get; set; } = new List<PurchaseOrderAdvanceAdjustment>();

    [ForeignKey("TransactionTypePurposeTranUid")]
    [InverseProperty("VoucherHeaders")]
    public virtual TransactionTypePurposeDetailM? TransactionTypePurposeTranU { get; set; }

    [InverseProperty("VoucherHeaderU")]
    public virtual ICollection<VoucherDetail> VoucherDetails { get; set; } = new List<VoucherDetail>();

    [InverseProperty("VoucherHeaderU")]
    public virtual ICollection<VoucherSchemeDetail> VoucherSchemeDetails { get; set; } = new List<VoucherSchemeDetail>();
}
