using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("FunReceivablesforHO")]
public partial class FunReceivablesforHo
{
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? UnAdjAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os0to30Days { get; set; }

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
    public decimal? Os181to365Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os366to730Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Os731to1095Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Above1095Days { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? UnAdjCreditAmt { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? BalUnAdjustedAmt { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionName { get; set; }
}
