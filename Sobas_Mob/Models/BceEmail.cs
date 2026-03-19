using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("bceEmail")]
public partial class BceEmail
{
    [StringLength(255)]
    public string? BeneficieryCode { get; set; }

    [StringLength(255)]
    public string? BeneficieryName { get; set; }

    public double? BeneficieryAcNo { get; set; }

    [Column("IFSCCode")]
    [StringLength(255)]
    public string? Ifsccode { get; set; }

    [Column("EMailID")]
    [StringLength(255)]
    public string? EmailId { get; set; }

    [Column("SECTION")]
    [StringLength(255)]
    public string? Section { get; set; }

    [Column("BRANCH")]
    [StringLength(255)]
    public string? Branch { get; set; }

    [Column("BANK NAME")]
    [StringLength(255)]
    public string? BankName { get; set; }

    [Column("BANK BRANCH")]
    [StringLength(255)]
    public string? BankBranch { get; set; }
}
