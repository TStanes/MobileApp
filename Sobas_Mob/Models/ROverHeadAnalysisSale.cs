using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("R_OverHeadAnalysis_Sales")]
public partial class ROverHeadAnalysisSale
{
    public int? GroupSlNo { get; set; }

    public int? SlNo { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TranType { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? TranTypeDesc { get; set; }

    public int? VoucherYear { get; set; }

    public int? VoucherMonth { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? VoucherMonthName { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? SubGroupCode { get; set; }

    [Column("Division_1", TypeName = "decimal(20, 3)")]
    public decimal? Division1 { get; set; }

    [Column("Division_2", TypeName = "decimal(20, 3)")]
    public decimal? Division2 { get; set; }

    [Column("Division_3", TypeName = "decimal(20, 3)")]
    public decimal? Division3 { get; set; }

    [Column("Division_4", TypeName = "decimal(20, 3)")]
    public decimal? Division4 { get; set; }

    [Column("Division_5", TypeName = "decimal(20, 3)")]
    public decimal? Division5 { get; set; }

    [Column("Division_6", TypeName = "decimal(20, 3)")]
    public decimal? Division6 { get; set; }

    [Column("Division_7", TypeName = "decimal(20, 3)")]
    public decimal? Division7 { get; set; }

    [Column("Division_8", TypeName = "decimal(20, 3)")]
    public decimal? Division8 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherMonthStartDate { get; set; }
}
