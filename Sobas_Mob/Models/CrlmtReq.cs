using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("CrlmtReq")]
public partial class CrlmtReq
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

    [StringLength(15)]
    [Unicode(false)]
    public string? Partycode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Partyname { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ToNet { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? PrevToNet { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CurCrLmt { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal PrevCreditLimit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleName { get; set; } = null!;

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

    public int? NoPreChequeBounce { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? ChqBounceAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? PrevChequebounceamt { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CreditDays { get; set; }

    public int PreCrDays { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? TotCollAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C0to90days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C91to120days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C121to180days { get; set; }

    [Column("CAbove180days", TypeName = "decimal(38, 3)")]
    public decimal? Cabove180days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C181to250days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C251to365days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? C366to460days { get; set; }

    [Column("CAbove460days", TypeName = "decimal(38, 3)")]
    public decimal? Cabove460days { get; set; }

    [Column("PTotCollAmt", TypeName = "decimal(38, 3)")]
    public decimal? PtotCollAmt { get; set; }

    [Column("PC0to90days", TypeName = "decimal(38, 3)")]
    public decimal? Pc0to90days { get; set; }

    [Column("PC91to120days", TypeName = "decimal(38, 3)")]
    public decimal? Pc91to120days { get; set; }

    [Column("PC121to180days", TypeName = "decimal(38, 3)")]
    public decimal? Pc121to180days { get; set; }

    [Column("PCAbove180days", TypeName = "decimal(38, 3)")]
    public decimal? Pcabove180days { get; set; }

    [Column("PC181to250days", TypeName = "decimal(38, 3)")]
    public decimal? Pc181to250days { get; set; }

    [Column("PC251to365days", TypeName = "decimal(38, 3)")]
    public decimal? Pc251to365days { get; set; }

    [Column("PC366to460days", TypeName = "decimal(38, 3)")]
    public decimal? Pc366to460days { get; set; }

    [Column("PCAbove460days", TypeName = "decimal(38, 3)")]
    public decimal? Pcabove460days { get; set; }
}
