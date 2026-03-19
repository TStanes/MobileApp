using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VoucherMatch")]
[Index("AccountUid", "IsActive", Name = "IX_VoucherMatch_AccountUID_IsActive_Includes")]
[Index("IsActive", Name = "IX_VoucherMatch_IsActive_Includes")]
[Index("DebitAmt", "VoucherMatchUid", "DocDate", "TransactionTypePurposeTranUid", "TransType", "VoucherUid", "PartyUid", "IsActive", "InventoryTransUid", "CreditAmt", Name = "_dta_index_VoucherMatch_7_357576312__K11_K1_K9_K3_K2_K5_K7_K13_K4_K12_10")]
[Index("CreditAmt", "VoucherMatchUid", "DocDate", "TransactionTypePurposeTranUid", "TransType", "VoucherUid", "PartyUid", "IsActive", "DebitAmt", "InventoryTransUid", Name = "_dta_index_VoucherMatch_7_357576312__K12_K1_K9_K3_K2_K5_K7_K13_K11_K4_10")]
[Index("CreatedDate", "VoucherMatchUid", "VoucherUid", Name = "_dta_index_VoucherMatch_7_357576312__K15_K1_K5")]
[Index("VoucherMatchUid", "DocDate", Name = "_dta_index_VoucherMatch_7_357576312__K1_K9")]
public partial class VoucherMatch
{
    [Key]
    [Column("VoucherMatchUID")]
    public Guid VoucherMatchUid { get; set; }

    public Guid TransType { get; set; }

    [Column("TransactionTypePurposeTranUID")]
    public Guid? TransactionTypePurposeTranUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransUid { get; set; }

    [Column("VoucherUID")]
    public Guid? VoucherUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

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

    [InverseProperty("VoucherMatchCru")]
    public virtual ICollection<VoucherMatchLink> VoucherMatchLinkVoucherMatchCrus { get; set; } = new List<VoucherMatchLink>();

    [InverseProperty("VoucherMatchDru")]
    public virtual ICollection<VoucherMatchLink> VoucherMatchLinkVoucherMatchDrus { get; set; } = new List<VoucherMatchLink>();
}
