using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwVoucherHeader
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? DebitBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DebitBranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [Column("RefVoucherUID")]
    public Guid? RefVoucherUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefVoucherDate { get; set; }

    [Column("StatusUID")]
    public Guid? StatusUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StatusCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StatusDesc { get; set; }

    [Column("PayModeUID", TypeName = "decimal(18, 0)")]
    public decimal? PayModeUid { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? PayMode { get; set; }

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

    [StringLength(20)]
    [Unicode(false)]
    public string? InvDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvDocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReferenceDate { get; set; }

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Soname { get; set; }

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

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [Column("RefPurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? RefPurchaseInvoiceHeaderUid { get; set; }

    [Column("RefInventoryServiceTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefInventoryServiceTransUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ServiceDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ServiceDocDate { get; set; }

    [Column("DepartmentalDivisionUID")]
    public Guid? DepartmentalDivisionUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ApprovedDate { get; set; }

    [StringLength(50)]
    public string? DepartmentalDivisionCode { get; set; }

    [StringLength(150)]
    public string? DepartmentalDivisionName { get; set; }

    [Column("ITSectionUID")]
    public Guid? ItsectionUid { get; set; }

    [Column("ITSectionCode")]
    [StringLength(50)]
    public string? ItsectionCode { get; set; }

    [Column("ITSectionDesc")]
    [StringLength(150)]
    public string? ItsectionDesc { get; set; }

    [StringLength(150)]
    public string? PrintDescription { get; set; }

    [Column("TDSPer", TypeName = "decimal(18, 2)")]
    public decimal? Tdsper { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? EduCessPer { get; set; }

    [Column("HCPer", TypeName = "decimal(18, 2)")]
    public decimal? Hcper { get; set; }

    [Column("IsIBT")]
    public bool? IsIbt { get; set; }

    [Column("OtherBranchIBT")]
    public bool? OtherBranchIbt { get; set; }

    [StringLength(177)]
    [Unicode(false)]
    public string? ReportVoucherNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionAbbriviation { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid? DivisionPrincipleUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    [Column("RefInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefInventoryTransUid { get; set; }

    [Column("RefServiceInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefServiceInventoryTransUid { get; set; }
}
