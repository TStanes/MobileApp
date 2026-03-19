using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class BceaccountCheck
{
    [Column("BCEAccountDetailsUID")]
    public Guid BceaccountDetailsUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("CashAccountUID")]
    public Guid? CashAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CashAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string CashAccountDescription { get; set; } = null!;

    [Column("BankAccountUID")]
    public Guid? BankAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BankAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string BankAccountDescription { get; set; } = null!;

    [Column("CollectionCashAccountUID")]
    public Guid? CollectionCashAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CollectionCashAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string CollectionCashAccountDescription { get; set; } = null!;

    [Column("BrMgrBankAccountUID")]
    public Guid? BrMgrBankAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BrMgrBankAccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string BrMgrBankAccountDescription { get; set; } = null!;
}
