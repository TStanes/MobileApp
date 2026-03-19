using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Turnover")]
public partial class Turnover
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

    public Guid? Partyuid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Partyname { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SalesVal { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SalesRtnVal { get; set; }

    [Column(TypeName = "decimal(19, 3)")]
    public decimal? ToNet { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? CreditLimit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    public Guid? Divisionprincipleuid { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? TotalOs { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OsLessThan90Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os91to180Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? OsAbove180Days { get; set; }

    public int? NoofChequebounce { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ChqBounceAmt { get; set; }
}
