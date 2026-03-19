using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EInvoiceBankInfo")]
public partial class EinvoiceBankInfo
{
    [Key]
    [StringLength(50)]
    public string BranchCode { get; set; } = null!;

    [StringLength(300)]
    public string? BranchName { get; set; }

    [StringLength(50)]
    public string? GlAccCode { get; set; }

    [StringLength(300)]
    public string? GlAccDesc { get; set; }

    [StringLength(300)]
    public string? BankName { get; set; }

    [StringLength(50)]
    public string? BankAccNo { get; set; }

    [Column("BankIFSCCode")]
    [StringLength(11)]
    public string? BankIfsccode { get; set; }

    [Column("BankUPIId")]
    [StringLength(50)]
    public string? BankUpiid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }
}
