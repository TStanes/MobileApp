using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BrMgrBankDebitDetail")]
public partial class BrMgrBankDebitDetail
{
    [Key]
    [Column("BrMgrBankDebitDetailUID")]
    public Guid BrMgrBankDebitDetailUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? TransactionTypeCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? StatementNo { get; set; }

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

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

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
}
