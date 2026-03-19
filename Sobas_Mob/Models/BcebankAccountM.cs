using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BCEBankAccountM")]
public partial class BcebankAccountM
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? InPaymentof { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? AccountNo { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? BankBranch { get; set; }

    [Column("IFSCCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ifsccode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    public Guid AccountUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string BankName { get; set; } = null!;

    [Column("BCEBankAccountUid")]
    public Guid BcebankAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Createddate { get; set; }

    [Column("modifiedby")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Modifiedby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(150)]
    public string? Email { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? SplAccountCode { get; set; }
}
