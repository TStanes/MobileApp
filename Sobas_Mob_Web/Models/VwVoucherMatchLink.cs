using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwVoucherMatchLink
{
    [Column("VoucherMatchLinkUID")]
    public Guid VoucherMatchLinkUid { get; set; }

    [Column("VoucherMatchDRUID")]
    public Guid VoucherMatchDruid { get; set; }

    [Column("DN_VoucherHeaderUID")]
    public Guid? DnVoucherHeaderUid { get; set; }

    [Column("DN_TransactionTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string DnTransactionTypeCode { get; set; } = null!;

    [Column("DN_TransactionTypeDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string DnTransactionTypeDesc { get; set; } = null!;

    [Column("DN_Purpose")]
    [StringLength(150)]
    [Unicode(false)]
    public string? DnPurpose { get; set; }

    [Column("DN_DocNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string DnDocNo { get; set; } = null!;

    [Column("DN_DocDate", TypeName = "datetime")]
    public DateTime DnDocDate { get; set; }

    [Column("DN_InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? DnInventoryTransUid { get; set; }

    [Column("DN_InvDocNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DnInvDocNo { get; set; }

    [Column("DN_InvDocDate", TypeName = "datetime")]
    public DateTime? DnInvDocDate { get; set; }

    [Column("DN_AccountUID")]
    public Guid DnAccountUid { get; set; }

    [Column("DN_AccountCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DnAccountCode { get; set; }

    [Column("DN_AccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string? DnAccountDescription { get; set; }

    [Column("DN_DueDate", TypeName = "datetime")]
    public DateTime? DnDueDate { get; set; }

    [Column("DN_DebitAmt", TypeName = "decimal(18, 3)")]
    public decimal DnDebitAmt { get; set; }

    [Column("DN_IsActive")]
    public bool DnIsActive { get; set; }

    [Column("DN_PartyUID")]
    public Guid DnPartyUid { get; set; }

    [Column("DN_PartyCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DnPartyCode { get; set; }

    [Column("DN_PartyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? DnPartyName { get; set; }

    [Column("VoucherMatchCRUID")]
    public Guid VoucherMatchCruid { get; set; }

    [Column("CN_VoucherHeaderUID")]
    public Guid? CnVoucherHeaderUid { get; set; }

    [Column("CN_TransactionTypeCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string CnTransactionTypeCode { get; set; } = null!;

    [Column("CN_TransactionTypeDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string CnTransactionTypeDesc { get; set; } = null!;

    [Column("CN_Purpose")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CnPurpose { get; set; }

    [Column("CN_DocNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string CnDocNo { get; set; } = null!;

    [Column("CN_DocDate", TypeName = "datetime")]
    public DateTime CnDocDate { get; set; }

    [Column("CN_InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? CnInventoryTransUid { get; set; }

    [Column("CN_InvDocNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CnInvDocNo { get; set; }

    [Column("CN_InvDocDate", TypeName = "datetime")]
    public DateTime? CnInvDocDate { get; set; }

    [Column("CN_AccountCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CnAccountCode { get; set; }

    [Column("CN_AccountDescription")]
    [StringLength(800)]
    [Unicode(false)]
    public string? CnAccountDescription { get; set; }

    [Column("CN_DueDate", TypeName = "datetime")]
    public DateTime? CnDueDate { get; set; }

    [Column("CN_CreditAmt", TypeName = "decimal(18, 3)")]
    public decimal CnCreditAmt { get; set; }

    [Column("CN_IsActive")]
    public bool CnIsActive { get; set; }

    [Column("CN_PartyCode")]
    [StringLength(15)]
    [Unicode(false)]
    public string? CnPartyCode { get; set; }

    [Column("CN_PartyName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? CnPartyName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdjAmt { get; set; }

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
}
