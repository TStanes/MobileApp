using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VoucherHeader")]
[Index("CreatedBy", Name = "IX_Cre_VH_RNO")]
[Index("IsActive", "TransactionTypeCode", Name = "IX_VoucherHeader_IsActive_TransactionTypeCode_Includes")]
[Index("IsActive", "VoucherDate", "TransactionTypeCode", Name = "IX_VoucherHeader_IsActive_VoucherDate_TransactionTypeCode_Includes")]
[Index("StatementNo", Name = "IX_VoucherHeader_StatementNo_Includes")]
[Index("TransactionTypeCode", Name = "IX_VoucherHeader_TransactionTypeCode_Includes")]
[Index("TransactionTypeCode", "StatusUid", Name = "IX_VoucherHeader_TransactionTypeCode_StatusUID_Includes")]
[Index("VoucherDate", Name = "IX_VoucherHeader_VoucherDate_Includes")]
[Index("VoucherDate", "TransactionTypeCode", "CreatedBy", Name = "IX_VoucherHeader_VoucherDate_TransactionTypeCode_CreatedBy_Includes")]
[Index("VoucherNo", Name = "IX_VoucherHeader_VoucherNo")]
[Index("TransactionTypeCode", "VoucherNo", "VoucherHeaderUid", Name = "_dta_index_VoucherHeader_7_1547152557__K14_K3_K1")]
[Index("StatusUid", "VoucherDate", "IsActive", "BranchUid", "DivisionUid", "VoucherHeaderUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K16_K4_K44_K5_K2_K1_K14")]
[Index("VoucherHeaderUid", "CreatedDate", "BranchUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K1_K46_K5_K14")]
[Index("IsActive", "VoucherHeaderUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K44_K1_K14_5")]
[Index("IsActive", "VoucherHeaderUid", "DivisionUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K44_K1_K2_K14_5")]
[Index("IsActive", "VoucherDate", "TransactionTypeCode", "VoucherHeaderUid", "StatusUid", "BranchUid", Name = "_dta_index_VoucherHeader_7_1547152557__K44_K4_K14_K1_K16_K5_3_7_18_19")]
[Index("IsActive", "VoucherDate", "VoucherHeaderUid", "StatusUid", "BranchUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K44_K4_K1_K16_K5_K14_3_7_18_19")]
[Index("CreatedDate", "VoucherHeaderUid", "BranchUid", "TransactionTypeCode", Name = "_dta_index_VoucherHeader_7_1547152557__K46_K1_K5_K14")]
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
}
