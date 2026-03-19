using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwVoucher
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionDesc { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Abbriviation { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [Column("BAddress1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Baddress1 { get; set; }

    [Column("BAddress2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Baddress2 { get; set; }

    [Column("BAddress3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Baddress3 { get; set; }

    [Column("BAddress4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Baddress4 { get; set; }

    [Column("StateUID")]
    public Guid? StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BranchType { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [Column("BCity")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Bcity { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? TransactionTypeDesc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? TransactionType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? UsedFor { get; set; }

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
    public string? DebitStateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DebitStateName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DebitBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DebitBranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [Column("RefVoucherUID")]
    public Guid? RefVoucherUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefVoucherDate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? RefTransactionTypeCode { get; set; }

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
    public string? PayModeDesc { get; set; }

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
    public string? InventoryDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InventoryDocDate { get; set; }

    [Column("InventoryTransactiontypesUID")]
    public Guid? InventoryTransactiontypesUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? InventoryTransactionTypeCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InventoryTransactionTypeDesc { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? InventoryTransactionType { get; set; }

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

    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    public int TransId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal LineNumber { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    public int AccountType { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string? AccountTypeDesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string LineDetail { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSegmentDesc { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemGroupDesc { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSubGroupDesc { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column("VechicleUID")]
    public Guid? VechicleUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VechicleNo { get; set; }

    [Column("RefPurchaseInvoiceHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal? RefPurchaseInvoiceHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PurchaseInvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PurchaseInvoiceDate { get; set; }

    [Column("RefInventoryServiceTransUID", TypeName = "decimal(18, 0)")]
    public decimal? RefInventoryServiceTransUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ServiceDocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ServiceDocDate { get; set; }

    [Column("DepartmentalDivisionUID")]
    public Guid? DepartmentalDivisionUid { get; set; }

    [StringLength(50)]
    public string? DepartmentalDivisionCode { get; set; }

    [StringLength(150)]
    public string? DepartmentalDivisionName { get; set; }

    [Column("ITSectionUID")]
    public Guid? ItsectionUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? OriginalPartyBranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? OriginalBranchName { get; set; }

    [Column("LnDivisionUID")]
    public Guid? LnDivisionUid { get; set; }

    [Column("LnDepartmentUID")]
    public Guid? LnDepartmentUid { get; set; }

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

    [Column("LRNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lrno { get; set; }

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string LnDivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string LnDivision { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string LnDivAbbri { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DepartmentDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? VechicleType { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string OriAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string OriAccountDescription { get; set; } = null!;

    public int Slno { get; set; }

    [Column("tVoucherNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TVoucherNo { get; set; }

    [Column("LineBranchUID")]
    public Guid? LineBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string LineBranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string LineBranchName { get; set; } = null!;

    [Column("OriginalAccountUID")]
    public Guid? OriginalAccountUid { get; set; }

    [Column("isIBT")]
    public bool? IsIbt { get; set; }

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

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }
}
