using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("R_OverHeadAnalysis_OtherAccounts")]
public partial class ROverHeadAnalysisOtherAccount
{
    public int? SlNo { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TranType { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TranTypeDesc { get; set; }

    [Column("AccountUID")]
    public Guid? AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountCode { get; set; }

    [Column("IsTTC")]
    public bool? IsTtc { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division1Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division2Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division3Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division4Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division5Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division6Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division7Percent { get; set; }

    [Column(TypeName = "decimal(8, 2)")]
    public decimal? Division8Percent { get; set; }
}
