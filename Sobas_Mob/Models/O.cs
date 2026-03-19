using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class O
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionAbbriviation { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SoCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AreaDesc { get; set; }

    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CreditLimit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;

    public Guid? DivisionPrincipleUid { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? TotalOs { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OsLessThan31Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os31to60Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os61to90Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os91to120Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os121to150Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os151to180Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OsAbove180Days { get; set; }

    public int? NoofChequebounce { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ChqBounceAmt { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CreditDays { get; set; }
}
