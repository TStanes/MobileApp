using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BCEAccountDetails")]
public partial class BceaccountDetail
{
    [Key]
    [Column("BCEAccountDetailsUID")]
    public Guid BceaccountDetailsUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("CashAccountUID")]
    public Guid? CashAccountUid { get; set; }

    [Column("BankAccountUID")]
    public Guid? BankAccountUid { get; set; }

    [Column("CollectionCashAccountUID")]
    public Guid? CollectionCashAccountUid { get; set; }

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

    [Column("BrMgrBankAccountUID")]
    public Guid? BrMgrBankAccountUid { get; set; }

    [Column("TAAccountUID")]
    public Guid? TaaccountUid { get; set; }
}
